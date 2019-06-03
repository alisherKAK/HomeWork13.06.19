using System;
using System.Windows;

namespace HomeWork13_06_19
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

        private void DownloadButtonClick(object sender, RoutedEventArgs e)
        {
            var downloadFileDomain = AppDomain.CreateDomain("Download File");

            downloadFileDomain.ExecuteAssembly(downloadFileDomain.BaseDirectory + "DownloadFile.exe");
            MessageBox.Show("Файл Скачен!\n" +
                            $"Его расопложение: {downloadFileDomain.BaseDirectory}\n" +
                            "Имя файла: TestFile.zip");
            AppDomain.Unload(downloadFileDomain);

        }

        private void FactorialCountingButtonClick(object sender, RoutedEventArgs e)
        {
            var factorialCountingDomain = AppDomain.CreateDomain("Factorial Count");

            factorialCountingDomain.ExecuteAssembly(factorialCountingDomain.BaseDirectory + "Factorial.exe");
            MessageBox.Show("Рандомный факториал найден!\n" +
                            $"Его расопложение: {factorialCountingDomain.BaseDirectory}\n" +
                            "Имя файла: FactorialResult.txt");
            AppDomain.Unload(factorialCountingDomain);
        }
    }
}
