using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using HelixToolkit.Wpf;
using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Media.Media3D;
using System.Reflection;
namespace AquaDesk.View
{
    /// <summary>
    /// Arac.xaml etkileşim mantığı
    /// </summary>
    public partial class Arac : UserControl
    {
        private AxisAngleRotation3D rotX = new AxisAngleRotation3D(new Vector3D(1, 0, 0), 0);
        private AxisAngleRotation3D rotY = new AxisAngleRotation3D(new Vector3D(0, 1, 0), 0);
        private AxisAngleRotation3D rotZ = new AxisAngleRotation3D(new Vector3D(0, 0, 1), 0);

        private Model3DGroup modelGroup = new Model3DGroup();
        public Arac()
        {
            InitializeComponent();
            LoadModel(@"C:\Users\hfk47\Desktop\AUV2025\AUV_UI2\img\AquaCorePCB v1.obj");
        }
        private void LoadModel(string path)
        {
            var importer = new ModelImporter();
            var model = importer.Load(path);

            var transformGroup = new Transform3DGroup();
            transformGroup.Children.Add(new RotateTransform3D(rotX));
            transformGroup.Children.Add(new RotateTransform3D(rotY));
            transformGroup.Children.Add(new RotateTransform3D(rotZ));
            model.Transform = transformGroup;

            modelGroup.Children.Clear();
            modelGroup.Children.Add(model);
            ModelContainer.Content = modelGroup;
        }

        private void SliderX_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            rotX.Angle = e.NewValue;
        }

        private void SliderY_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            rotY.Angle = e.NewValue;
        }

        private void SliderZ_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            rotZ.Angle = e.NewValue;
        }
    }
}
