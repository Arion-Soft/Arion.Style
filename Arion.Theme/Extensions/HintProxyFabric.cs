using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using MaterialDesignThemes.Wpf;

namespace Arion.Theme.Extensions
{
    public static partial class HintProxyFabric
    {
        private sealed class HintProxyBuilder
        {
            private readonly Func<Control, bool> _canBuild;
            private readonly Func<Control, IHintProxy> _build;

            public HintProxyBuilder(Func<Control, bool> canBuild, Func<Control, IHintProxy> build)
            {
                _canBuild = canBuild ?? throw new ArgumentNullException(nameof(canBuild));
                _build = build ?? throw new ArgumentNullException(nameof(build));
            }

            public bool CanBuild(Control control) => _canBuild(control);
            public IHintProxy Build(Control control) => _build(control);
        }

        private static readonly List<HintProxyBuilder> Builders = new List<HintProxyBuilder>();

        static HintProxyFabric()
        {
            Builders.Add(new HintProxyBuilder(c => c is ComboBox, c => new HintProxyFabric.ComboBoxHintProxy((ComboBox)c)));
            Builders.Add(new HintProxyBuilder(c => c is TextBox, c => new HintProxyFabric.TextBoxHintProxy((TextBox)c)));
            Builders.Add(new HintProxyBuilder(c => c is RichTextBox, c => new HintProxyFabric.RichTextBoxHintProxy((RichTextBox)c)));
            Builders.Add(new HintProxyBuilder(c => c is PasswordBox, c => new HintProxyFabric.PasswordBoxHintProxy((PasswordBox)c)));
        }

        public static void RegisterBuilder(Func<Control, bool> canBuild, Func<Control, IHintProxy> build)
            => Builders.Add(new HintProxyBuilder(canBuild, build));

        public static IHintProxy Get(Control control)
        {
            if (control is null) return null;
            var builder = Builders.FirstOrDefault(v => v.CanBuild(control));
            return builder?.Build(control);
        }
    }
}
