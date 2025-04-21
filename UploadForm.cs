using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AUV_UI
{
    public partial class UploadForm : Form
    {
        AnaForm Ana;
        private ImageList imageList;
        string[] selectedPaths;

        // Çoklu seçim için düğümleri saklayacak bir liste
        private List<TreeNode> selectedNodes = new List<TreeNode>();

        public UploadForm(AnaForm ana)
        {
            Ana = ana;
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            // ImageList oluştur ve ikonları ekle
            imageList = new ImageList();
            imageList.Images.Add("folder", Properties.Resources.folder); // Klasör ikonu
            imageList.Images.Add("file", Properties.Resources.document);     // Dosya ikonu
            fileTreeView.ImageList = imageList;
            fileTreeView.HideSelection = false;
            fileTreeView.ShowPlusMinus = true;
            fileTreeView.ShowRootLines = true;

            // TreeView olaylarını bağla
            fileTreeView.NodeMouseClick += FileTreeView_NodeMouseClick;

            LoadRootDirectories();
        }

        private void LoadRootDirectories()
        {
            try
            {
                var command = Ana.RaspiSSHClient.CreateCommand("ls -F /");
                var result = command.Execute();
                var entries = result.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                var treeView = (TreeView)this.Controls["fileTreeView"];
                treeView.Nodes.Clear();

                foreach (var entry in entries)
                {
                    // İkon tipi belirle (klasör veya dosya)
                    string imageKey = entry.EndsWith("/") ? "folder" : "file";
                    string entryName = entry.TrimEnd('/');

                    var node = new TreeNode(entryName)
                    {
                        Tag = "/" + entryName, // Tam yolu tag olarak sakla
                        ImageKey = imageKey, // Normal ikon
                        SelectedImageKey = imageKey // Seçildiğinde kullanılacak ikon
                    };
                    treeView.Nodes.Add(node);

                    // Eğer klasörse dummy node ekle
                    if (imageKey == "folder")
                    {
                        node.Nodes.Add(new TreeNode("..."));
                    }
                }

                treeView.BeforeExpand += TreeView_BeforeExpand;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kök dizinler yüklenirken hata oluştu: {ex.Message}");
            }
        }

        private void TreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            var node = e.Node;

            if (node.Nodes.Count == 1 && node.Nodes[0].Text == "...")
            {
                node.Nodes.Clear(); // Dummy node'u kaldır
                LoadSubDirectories(node);
            }
        }

        private void LoadSubDirectories(TreeNode node)
        {
            try
            {
                // Geçerli düğümün yolu
                string path = node.Tag.ToString();

                // Alt dizinleri listelemek için komut oluştur
                var command = Ana.RaspiSSHClient.CreateCommand($"ls -F \"{path}\"");
                var result = command.Execute();

                if (string.IsNullOrWhiteSpace(result))
                {
                    //MessageBox.Show($"Dizin içeriği alınamadı: {path}");
                    return;
                }

                var entries = result.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var entry in entries)
                {
                    // İkon tipi belirle (klasör veya dosya)
                    string imageKey = entry.EndsWith("/") ? "folder" : "file";
                    string entryName = entry.TrimEnd('/');

                    // Tam Linux dizin yolunu oluştur
                    string fullPath = path.EndsWith("/") ? path + entryName : path + "/" + entryName;

                    var subNode = new TreeNode(entryName)
                    {
                        Tag = fullPath, // Tam yolu tag olarak sakla
                        ImageKey = imageKey,
                        SelectedImageKey = imageKey
                    };

                    // Eğer klasörse dummy node ekle
                    if (imageKey == "folder")
                    {
                        subNode.Nodes.Add(new TreeNode("..."));
                    }
                    node.Nodes.Add(subNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Alt dizinler yüklenirken hata oluştu: {ex.Message}");
            }
        }

        private void FileTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var node = e.Node;

            // Sadece klasörlerin seçilmesine izin ver
            if (node.ImageKey != "folder")
            {
                MessageBox.Show("Sadece klasörler seçilebilir!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Eğer klasör değilse işlemi iptal et
            }

            // Önceki seçimleri temizle
            ClearSelection();

            // Yeni seçimi uygula
            selectedNodes.Add(node);
            node.BackColor = Color.LightBlue;
            node.ForeColor = Color.Black;

            // Seçili düğümün yolunu bir string değişkene aktar
            selectedPaths = new[] { node.Tag.ToString() };

            // Seçili düğümün yolunu TextBox'a yazdır
            textBox1.Text = string.Join(", ", selectedPaths);

            // selectedPaths değişkeni ile istediğiniz işlemi yapabilirsiniz
        }

        private void ClearSelection()
        {
            // Seçimi temizle
            foreach (var node in selectedNodes)
            {
                node.BackColor = fileTreeView.BackColor;
                node.ForeColor = fileTreeView.ForeColor;
            }
            selectedNodes.Clear();
        }        

        private void DosyaGonder(object sender, EventArgs e)
        {
            Ana.karsidosyayolu = selectedPaths[0];
            this.Close();
        }

        private void NewFolderAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
