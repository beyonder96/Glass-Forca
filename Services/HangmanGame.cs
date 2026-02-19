using System;
using System.Collections.Generic;
using System.Linq;

namespace ionized_pulsar.Services
{
    public enum GameStatus
    {
        Playing,
        Won,
        Lost
    }

    public record WordItem(string Text, string Hint);
    public record Category(string Name, List<WordItem> Words);
    public record WordData(List<Category> Categories);

    public class HangmanGame
    {
        public string WordToGuess { get; private set; } = "";
        public string CurrentHint { get; private set; } = "";
        public string CurrentCategory { get; private set; } = "";
        public HashSet<char> GuessedLetters { get; private set; } = new HashSet<char>();
        public int MaxLives { get; private set; } = 6;
        public int CurrentLives { get; private set; }
        public GameStatus Status { get; private set; } = GameStatus.Playing;

        private List<Category> _allCategories = new();
        private List<WordItem> _activeWordList = new();
        
        public event Action? OnStateChanged;

        public void InitializeData(List<Category> categories)
        {
            _allCategories = categories;
            if (_allCategories.Any())
            {
                SelectCategory(_allCategories.First().Name);
            }
        }

        public IEnumerable<string> GetCategories() => _allCategories.Select(c => c.Name);

        public void SelectCategory(string categoryName)
        {
            var category = _allCategories.FirstOrDefault(c => c.Name == categoryName);
            if (category != null)
            {
                CurrentCategory = category.Name;
                _activeWordList = category.Words;
                StartNewGame();
            }
        }

        public void StartNewGame()
        {
            if (!_activeWordList.Any()) return;

            var random = new Random();
            var selected = _activeWordList[random.Next(_activeWordList.Count)];
            WordToGuess = selected.Text.ToUpper();
            CurrentHint = selected.Hint;
            
            GuessedLetters.Clear();
            CurrentLives = MaxLives;
            Status = GameStatus.Playing;
            NotifyStateChanged();
        }

        public void Guess(char letter)
        {
            if (Status != GameStatus.Playing) return;
            
            letter = char.ToUpper(letter);
            if (GuessedLetters.Contains(letter)) return;

            GuessedLetters.Add(letter);

            // Handle accents if necessary, but for now exact match
            if (!WordToGuess.Contains(letter))
            {
                CurrentLives--;
            }

            CheckGameStatus();
            NotifyStateChanged();
        }

        private void CheckGameStatus()
        {
            if (CurrentLives <= 0)
            {
                Status = GameStatus.Lost;
            }
            else if (WordToGuess.All(c => GuessedLetters.Contains(c)))
            {
                Status = GameStatus.Won;
            }
        }
        
        private void NotifyStateChanged() => OnStateChanged?.Invoke();
    }
}
