using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Apataitala.Modeli;
using System.IO;
using Apataitala.Kontroller;

namespace Apataitala
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int[] timeA;
        int[] timeB;
        int[] timeC;
        int[] timeD;
        int[] timeI;
        int[] timeF;
        public List<Goroda> Chasy = new List<Goroda>();
        public List<int> GorodaIndexes = new List<int>();

        private void Vybrat(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.ShowDialog();
                List<string> SpisokGorodov = new List<string>();
                if (dialog.FileName != "")
                {
                    string productString = File.ReadAllText(dialog.FileName);
                    SpisokGorodov.AddRange(productString.Split('\n'));
                }
                else
                {
                    MessageBox.Show("Выберите файл");
                    return;
                }
                timeA = new int[SpisokGorodov.Count];
                timeB = new int[SpisokGorodov.Count];
                timeC = new int[SpisokGorodov.Count];
                timeD = new int[SpisokGorodov.Count];
                timeI = new int[SpisokGorodov.Count];
                timeF = new int[SpisokGorodov.Count];
                Chasy.Clear();
                Spisok.ItemsSource = null;
                for (int i = 0; i < SpisokGorodov.Count; i++)
                {
                    if (SpisokGorodov[i] != "")
                    {
                        string[] data = new string[7];
                        data = SpisokGorodov[i].Split(':');
                        Chasy.Add(new Gorod(data[0], Int32.Parse(data[1]), Int32.Parse(data[2]), Int32.Parse(data[3]), Int32.Parse(data[4]), Int32.Parse(data[5]), Int32.Parse(data[6])));
                        timeA[i] = Int32.Parse(data[1]);
                        timeB[i] = Int32.Parse(data[2]);
                        timeC[i] = Int32.Parse(data[3]);
                        timeD[i] = Int32.Parse(data[4]);
                        timeI[i] = Int32.Parse(data[5]);
                        timeF[i] = Int32.Parse(data[6]);
                    }
                }
                Spisok.ItemsSource = Chasy;
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте формат файла и путь");
            }
        }
    }
   
 
}
