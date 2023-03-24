using System;
using System.Windows;
using System.Windows.Controls;

namespace Arion.Style.Theme.Extensions
{
    public static partial class HintProxyFabric
{
    private sealed class PasswordBoxHintProxy : IHintProxy
    {
        private readonly PasswordBox _passwordBox;

        public bool IsEmpty() => string.IsNullOrEmpty(_passwordBox.Password);

        public object Content => _passwordBox.Password;

        public bool IsLoaded => _passwordBox.IsLoaded;

        public bool IsVisible => _passwordBox.IsVisible;

        public bool IsFocused() => _passwordBox.IsKeyboardFocusWithin;

        public event EventHandler ContentChanged;
        public event EventHandler IsVisibleChanged;
        public event EventHandler Loaded;
        public event EventHandler FocusedChanged;

        public PasswordBoxHintProxy(PasswordBox passwordBox)
        {
            _passwordBox = passwordBox ?? throw new ArgumentNullException(nameof(passwordBox));
            _passwordBox.PasswordChanged += PasswordBoxPasswordChanged;
            _passwordBox.Loaded += PasswordBoxLoaded;
            _passwordBox.IsVisibleChanged += PasswordBoxIsVisibleChanged;
            _passwordBox.IsKeyboardFocusWithinChanged += PasswordBoxIsKeyboardFocusedChanged;
        }

        private void PasswordBoxIsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
            => FocusedChanged?.Invoke(this, EventArgs.Empty);

        private void PasswordBoxIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
            => IsVisibleChanged?.Invoke(this, EventArgs.Empty);

        private void PasswordBoxLoaded(object sender, RoutedEventArgs e)
            => Loaded?.Invoke(this, EventArgs.Empty);

        private void PasswordBoxPasswordChanged(object sender, RoutedEventArgs e)
            => ContentChanged?.Invoke(this, EventArgs.Empty);

        public void Dispose()
        {
            _passwordBox.PasswordChanged -= PasswordBoxPasswordChanged;
            _passwordBox.Loaded -= PasswordBoxLoaded;
            _passwordBox.IsVisibleChanged -= PasswordBoxIsVisibleChanged;
            _passwordBox.IsKeyboardFocusWithinChanged -= PasswordBoxIsKeyboardFocusedChanged;
        }
    }
}
}
