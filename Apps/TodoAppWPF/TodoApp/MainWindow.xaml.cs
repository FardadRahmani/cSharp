﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace TodoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddTodoButton_Click(object sender, RoutedEventArgs e)
        {
            string todoText= TodoInput.Text;
            //MessageBox.Show(todoText);

            if(!string.IsNullOrEmpty(todoText) )
            {
                /*Or:
                 *  TextBlock todoItem = new TextBlock();
                 *  todoItem.Text = todoText;
                 * */
                TextBlock todoItem = new TextBlock
                {
                    Text = todoText,
                    Margin = new Thickness(10),
                    Foreground = new SolidColorBrush(Colors.White),
                };
                TodoList.Children.Add(todoItem);

                TodoInput.Clear();
                
            }

        }
    }
}