using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using TextTableTool;

namespace TextTool
{
    class TextTableDefinitionEditor : System.Windows.Forms.RichTextBox
    {
        private const int   WM_PAINT            = 0x00f;
        private Boolean     m_allowPainting     = true;
        private Font        m_KeyWordFont       = new Font(DefaultFont, FontStyle.Regular);
        private Color       m_KeyWordColor      = Color.Blue;
        private Font        m_IntegerFont       = new Font(DefaultFont, FontStyle.Regular);
        private Color       m_IntegerColor      = Color.OrangeRed;
        private Font        m_IdentifierFont    = new Font(DefaultFont, FontStyle.Regular);
        private Color       m_IdentifierColor   = Color.DarkGray;
        private int m_lastContentLength = 0;

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (m.Msg == WM_PAINT)
            {
                if (isPaintingAllowed())
                {
                    base.WndProc(ref m);
                }
                else
                {
                    m.Result = IntPtr.Zero;
                }
            }
            else
            {
                base.WndProc(ref m);
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            suppressPainting();
            int LastSelectionStart = SelectionStart;
            int LastSelectionLength = SelectionLength;

            ANTLRStringStream AntLRStream = new ANTLRStringStream(Text);
            TextTableLexer lexer = new TextTableLexer(AntLRStream);

            IToken token;
            while ((token = lexer.NextToken()).Type != TextTableLexer.EOF)
            {
                if ((LastSelectionStart >= token.StartIndex &&
                     LastSelectionStart <= token.StopIndex + 1) ||
                    (Math.Abs(m_lastContentLength - TextLength) > 10 )
                    )
                {
                    performHighlightingOnToken(ref token);
                }

            }
            SelectionStart = LastSelectionStart;
            SelectionLength = LastSelectionLength;
            SelectionColor = ForeColor;
            m_lastContentLength = Text.Length;
            allowPainting();
        }

        private void performHighlightingOnToken(ref IToken token)
        {
            SelectionStart = token.StartIndex;
            SelectionLength = token.Text.Length;
            SelectionFont = Font;
            SelectionColor = ForeColor;
            if (token.Type == TextTableLexer.PLAIN ||
                token.Type == TextTableLexer.BEGIN ||
                token.Type == TextTableLexer.FROM ||
                token.Type == TextTableLexer.TO ||
                token.Type == TextTableLexer.LENGTH ||
                token.Type == TextTableLexer.END ||
                token.Type == TextTableLexer.ALIGN_LEFT ||
                token.Type == TextTableLexer.ALIGN_RIGHT)
            {
                SelectionColor = m_KeyWordColor;
                SelectionFont = m_KeyWordFont;
            }
            if (token.Type == TextTableLexer.INT)
            {
                SelectionColor = m_IntegerColor;
                SelectionFont = m_IntegerFont;
            }
            if (token.Type == TextTableLexer.ID)
            {
                SelectionColor = m_IdentifierColor;
                SelectionFont = m_IdentifierFont;
            }
        }

        private void suppressPainting()
        {
            m_allowPainting = false;
        }

        private void allowPainting()
        {
            m_allowPainting = true;
        }

        private Boolean isPaintingAllowed()
        {
            return m_allowPainting;
        }

        #region properties
        public Font KeyWordFont
        {
            get { return m_KeyWordFont; }
            set { this.m_KeyWordFont = value; }
        }

        public Color KeyWordColor
        {
            get { return m_KeyWordColor; }
            set { this.m_KeyWordColor = value; }
        }

        public Font IntegerFont
        {
            get { return m_IntegerFont; }
            set { this.m_IntegerFont = value; }
        }

        public Color IntegerColor
        {
            get { return m_IntegerColor; }
            set { this.m_IntegerColor = value; }
        }

        public Font IdentifierFont
        {
            get { return m_IdentifierFont; }
            set { this.m_IdentifierFont = value; }
        }

        public Color IdentifierColor
        {
            get { return m_IdentifierColor; }
            set { this.m_IdentifierColor = value; }
        }
        #endregion 
    }
}
