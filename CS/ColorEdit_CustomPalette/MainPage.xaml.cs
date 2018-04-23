using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;
using DevExpress.Xpf.Editors;

namespace ColorEdit_CustomPalette {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            // Removes the 'Standard Colors' palette.
            colorEdit1.Palettes.Remove(colorEdit1.Palettes["Standard Colors"]);
            // Adds a custom gradient palette.
            colorEdit1.Palettes.Add(CustomPalette.CreateGradientPalette("Apex Colors", PredefinedColorCollections.Apex));
            // Adds a new palette with three custom RGB colors.
           colorEdit1.Palettes.Add(new CustomPalette("Custom RGB Colors", new List<Color>() {
              Color.FromArgb(100, 150, 18, 30),
              Color.FromArgb(255, 20, 40, 20),
              Color.FromArgb(255, 88, 73, 29) }));
        }
    }
}
