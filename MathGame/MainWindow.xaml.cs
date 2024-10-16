using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MathGame
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
                "🐶", "🐶", "🐱", "🐱", "🦁", "🦁", "🐯", "🐯",
                "🐴", "🐴", "🦓", "🦓", "🐮", "🐮", "🐷", "🐷"
            };

            Random random = new Random();

            // Обходим все TextBlock в Grid
            foreach (TextBlock textBlock in MainGrid.Children.OfType<TextBlock>())
            {
                int index = random.Next(animalEmoji.Count);
                string nextEmoji = animalEmoji[index];
                textBlock.Text = nextEmoji;
                animalEmoji.RemoveAt(index);
            }
        }
    }
}

