﻿//----------------------------------------------------------------------- 
// PDS.Witsml.Studio, 2016.1
//
// Copyright 2016 Petrotechnical Data Systems
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//-----------------------------------------------------------------------

using System;
using System.Windows;
using System.Xml.Linq;
using Caliburn.Micro;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Highlighting;
using PDS.Witsml.Studio.Core.Runtime;

namespace PDS.Witsml.Studio.Core.ViewModels
{
    /// <summary>
    /// Manages the behavior of the text editor control.
    /// </summary>
    /// <seealso cref="Caliburn.Micro.Screen" />
    public class TextEditorViewModel : Screen
    {
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(TextEditorViewModel));
        private TextEditor _textEditor;

        /// <summary>
        /// Initializes a new instance of the <see cref="TextEditorViewModel" /> class.
        /// </summary>
        /// <param name="runtime">The runtime service.</param>
        /// <param name="language">The language.</param>
        /// <param name="isReadOnly">if set to <c>true</c> the control is read only.</param>
        public TextEditorViewModel(IRuntimeService runtime, string language = null, bool isReadOnly = false)
        {
            Runtime = runtime;
            Language = language;
            IsReadOnly = isReadOnly;
            Document = new TextDocument();
        }

        /// <summary>
        /// Gets the runtime service.
        /// </summary>
        /// <value>The runtime service.</value>
        public IRuntimeService Runtime { get; private set; }

        private TextDocument _document;

        /// <summary>
        /// Gets or sets the document.
        /// </summary>
        /// <value>The document.</value>
        public TextDocument Document
        {
            get { return _document; }
            set
            {
                if (!ReferenceEquals(_document, value))
                {
                    _document = value;
                    NotifyOfPropertyChange(() => Document);
                }
            }
        }

        private string _language;

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        /// <value>The language.</value>
        public string Language
        {
            get { return _language; }
            set
            {
                if (!string.Equals(_language, value))
                {
                    _language = value;
                    _syntax = HighlightingManager.Instance.GetDefinition(value);
                    NotifyOfPropertyChange(() => Language);
                    NotifyOfPropertyChange(() => Syntax);
                }
            }
        }

        private IHighlightingDefinition _syntax;

        /// <summary>
        /// Gets or sets the syntax.
        /// </summary>
        /// <value>The syntax.</value>
        public IHighlightingDefinition Syntax
        {
            get { return _syntax; }
            set
            {
                if (!ReferenceEquals(_syntax, value))
                {
                    _syntax = value;
                    _language = value.Name;
                    NotifyOfPropertyChange(() => Syntax);
                    NotifyOfPropertyChange(() => Language);
                }
            }
        }

        private bool _isReadOnly;

        /// <summary>
        /// Gets or sets the read only flag.
        /// </summary>
        /// <value>Is read only.</value>
        public bool IsReadOnly
        {
            get { return _isReadOnly; }
            set
            {
                if (_isReadOnly != value)
                {
                    _isReadOnly = value;
                    NotifyOfPropertyChange(() => IsReadOnly);
                }
            }
        }

        private bool _isWordWrapEnabled;

        /// <summary>
        /// Gets or sets a value indicating whether word wrap is enabled.
        /// </summary>
        /// <value><c>true</c> if word wrap is enabled; otherwise, <c>false</c>.</value>
        public bool IsWordWrapEnabled
        {
            get { return _isWordWrapEnabled; }
            set
            {
                if (_isWordWrapEnabled != value)
                {
                    _isWordWrapEnabled = value;
                    NotifyOfPropertyChange(() => IsWordWrapEnabled);
                }
            }
        }

        private bool _isPrettyPrintEnabled;

        /// <summary>
        /// Gets or sets whether this instance uses pretty print.
        /// </summary>
        /// <value>If this instance will use pretty print.</value>
        public bool IsPrettyPrintEnabled
        {
            get { return _isPrettyPrintEnabled; }
            set
            {
                if (_isPrettyPrintEnabled != value)
                {
                    _isPrettyPrintEnabled = value;
                    NotifyOfPropertyChange(() => IsPrettyPrintEnabled);
                }
            }
        }

        private bool _isPrettyPrintAllowed;

        /// <summary>
        /// Gets or sets a value indicating whether this instance allows pretty print.
        /// </summary>
        /// <value><c>true</c> if this instance allows pretty print; otherwise, <c>false</c>.</value>
        public bool IsPrettyPrintAllowed
        {
            get { return _isPrettyPrintAllowed; }
            set
            {
                if (_isPrettyPrintAllowed != value)
                {
                    _isPrettyPrintAllowed = value;
                    NotifyOfPropertyChange(() => IsPrettyPrintAllowed);
                }
            }
        }

        private bool _isScrollingEnabled;

        /// <summary>
        /// Gets or sets a value indicating whether scrolling is enabled.
        /// </summary>
        /// <value><c>true</c> if scrolling is enabled; otherwise, <c>false</c>.</value>
        public bool IsScrollingEnabled
        {
            get { return _isScrollingEnabled; }
            set
            {
                if (_isScrollingEnabled != value)
                {
                    _isScrollingEnabled = value;
                    NotifyOfPropertyChange(() => IsScrollingEnabled);
                }
            }
        }

        private bool _canCut;

        /// <summary>
        /// Gets or sets a value indicating whether the Cut command can be executed.
        /// </summary>
        /// <value><c>true</c> if Cut can be executed; otherwise, <c>false</c>.</value>
        public bool CanCut
        {
            get { return _canCut; }
            set
            {
                if (_canCut != value)
                {
                    _canCut = value;
                    NotifyOfPropertyChange(() => CanCut);
                }
            }
        }

        private bool _canCopy;

        /// <summary>
        /// Gets or sets a value indicating whether the Copy command can be executed.
        /// </summary>
        /// <value><c>true</c> if Copy can be executed; otherwise, <c>false</c>.</value>
        public bool CanCopy
        {
            get { return _canCopy; }
            set
            {
                if (_canCopy != value)
                {
                    _canCopy = value;
                    NotifyOfPropertyChange(() => CanCopy);
                }
            }
        }

        private bool _canPaste;

        /// <summary>
        /// Gets or sets a value indicating whether the Paste command can be executed.
        /// </summary>
        /// <value><c>true</c> if Paste can be executed; otherwise, <c>false</c>.</value>
        public bool CanPaste
        {
            get { return _canPaste; }
            set
            {
                if (_canPaste != value)
                {
                    _canPaste = value;
                    NotifyOfPropertyChange(() => CanPaste);
                }
            }
        }

        /// <summary>
        /// Sets the document text.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetText(string text)
        {
            if (IsPrettyPrintAllowed && IsPrettyPrintEnabled)
            {
                try
                {
                    text = XDocument.Parse(text).ToString();
                }
                catch (Exception ex)
                {
                    _log.Warn($"Error parsing XML:{Environment.NewLine}{text}{Environment.NewLine}{Environment.NewLine}{ex}");
                }
            }
            Runtime.Invoke(() =>
            {
                Document.Text = text;
            });
        }

        /// <summary>
        /// Appends the specified text to the document.
        /// </summary>
        /// <param name="text">The text to append.</param>
        public void Append(string text)
        {
            Runtime.Invoke(() =>
            {
                Document.Insert(Document.TextLength, text);
            });
        }

        /// <summary>
        /// Cuts the currently selected editor text.
        /// </summary>
        public void Cut()
        {
            Runtime.Invoke(() =>
            {
                Clipboard.SetText(_textEditor.SelectedText);
                Document.Replace(_textEditor.SelectionStart, _textEditor.SelectionLength, string.Empty);
            });
        }

        /// <summary>
        /// Copies the currently selected editor text.
        /// </summary>
        public void Copy()
        {
            Runtime.Invoke(() => Clipboard.SetText(_textEditor.SelectedText));
        }

        /// <summary>
        /// Pastes the clipboard text into the editor.
        /// </summary>
        public void Paste()
        {
            Runtime.Invoke(() => Document.Replace(_textEditor.SelectionStart, _textEditor.SelectionLength, Clipboard.GetText()));
        }

        /// <summary>
        /// Selects all editor textx.
        /// </summary>
        public void SelectAll()
        {
            Runtime.Invoke(() => _textEditor.SelectAll());
        }

        /// <summary>
        /// Copies all editor text to the clipboard.
        /// </summary>
        public void CopyAll()
        {
            Runtime.Invoke(() => Clipboard.SetText(Document.Text));
        }

        /// <summary>
        /// Replaces the editor text with the clipboard text.
        /// </summary>
        public void Replace()
        {
            Runtime.Invoke(() => Document.Text = Clipboard.GetText());
        }

        /// <summary>
        /// Clears the editor text.
        /// </summary>
        public void Clear()
        {
            Runtime.Invoke(() => Document.Text = string.Empty);
        }

        /// <summary>
        /// Refreshes the context menu.
        /// </summary>
        /// <param name="control">The control.</param>
        public void RefreshContextMenu(TextEditor control)
        {
            _textEditor = control;

            Runtime.Invoke(() =>
            {
                CanCopy = control.SelectionLength > 0;
                CanPaste = !IsReadOnly && Clipboard.ContainsText();
                CanCut = !IsReadOnly && CanCopy;
            });
        }

        /// <summary>
        /// Scrolls to the bottom of the current text content.
        /// </summary>
        /// <param name="control">The control.</param>
        public void ScrollToBottom(TextEditor control)
        {
            if (IsScrollingEnabled)
            {
                control.ScrollToEnd();
            }
        }
    }
}
