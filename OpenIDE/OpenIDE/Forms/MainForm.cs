using MyvarUI;
using MyvarUI.Events;
using MyvarUI.Window;
using MyvarUI.Window.Controls;
using System;
using System.Diagnostics;

namespace OpenIDE.Forms
{
    public class MainForm : Form
    {
        private ContextMenu _menu;
        /* File Menu */
        private ContextMenuButton _fileContextButton;
        private ContextMenuButton _fileExitContextButton;
        private ContextMenuButton _fileOpenContextButton;
        private ContextMenuButton _fileSaveContextButton;

        /* Edit Menu */
        private ContextMenuButton _editContextButton;

        public MainForm()
        {
            BackgroundColor = Color.FromArgb(0x1E1E1E);
            InitControls();
        }

        private void InitControls()
        {
            _menu = new ContextMenu();
            _menu.BackgroundColor = Color.FromArgb(0x333333);

            /* File Menu */
            _fileContextButton = NewContextButton("File");

            /* Open */
            _fileOpenContextButton = NewContextButton("Open");
            _fileContextButton.Add(_fileOpenContextButton);

            /* Save */
            _fileSaveContextButton = NewContextButton("Save");
            _fileContextButton.Add(_fileSaveContextButton);

            /* Divider */ _fileContextButton.Add(newContextDivider());

            /* Exit Button */
            _fileExitContextButton = NewContextButton("Exit");
            _fileExitContextButton.MouseDown += FileExitClick;
            _fileContextButton.Add(_fileExitContextButton);

            /* Edit Menu */
            _editContextButton = NewContextButton("Edit");

            _menu.Add(_fileContextButton);
            _menu.Add(_editContextButton);

            Controls.Add(_menu);
        }

        private ContextMenuButton NewContextButton(string text)
        {
            var re = new ContextMenuButton();
            re.Text = text;
            re.BackgroundColor = Color.FromArgb(0x3f3f46);
            re.ForegroundColor = Color.FromArgb(0xcccccc);
            re.Font = Font.FontFromName("Droid Sans Mono");
            return re;
        }

        private ContextMenuDivider newContextDivider()
        {
           return new ContextMenuDivider(){ BackgroundColor = Color.Gray };
        }

        private void FileExitClick(object sender, MouseEventArgs args)
        {
            Debug.WriteLine("Exit(0)");
            Environment.Exit(0);
        }
    }
}