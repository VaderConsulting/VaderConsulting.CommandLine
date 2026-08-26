using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VaderConsulting.CommandLine
{
    public class TextTraceListener : TextWriterTraceListener
    {
        TextBox _TextboxOutput = null;
        StatusStrip _StatusStripOutput = null;
        ToolStripStatusLabel _ToolStripOutput = null;
        frmProgress _ProgressForm = null;

        public TextTraceListener(TextBox output)
        {
            _TextboxOutput = output;
            _ProgressForm = new frmProgress();
        }

        public TextTraceListener(StatusStrip output)
        {
            _StatusStripOutput = output;
            _ProgressForm = new frmProgress();
        }

        public TextTraceListener(ToolStripStatusLabel output)
        {
            _ToolStripOutput = output;
            _ProgressForm = new frmProgress();

            _ProgressForm.Show();
        }

        public override void Write(string message)
        {
            base.Write(message);

            if (_TextboxOutput != null)
            {
                _TextboxOutput.AppendText(message); // When character data is written, append it to the text box.
            }

            if (_StatusStripOutput != null)
            {
                _StatusStripOutput.Text = message; // When character data is written, send it to the status strip.
            }

            if (_ToolStripOutput != null)
            {
                _ToolStripOutput.Text = message; // When character data is written, send it to the status strip.
            }

            if (!_ProgressForm.Visible)
            {
                _ProgressForm.Show();
                //_ProgressForm.WindowState = FormWindowState.Minimized;
            }

            _ProgressForm.AddText(message + (char)13 + (char)10);
        }

        public override void WriteLine(string message)
        {
            base.WriteLine(message);

            if (_TextboxOutput != null)
            {
                _TextboxOutput.AppendText(message); // When character data is written, append it to the text box.
            }

            if (_StatusStripOutput != null)
            {
                _StatusStripOutput.Text = message; // When character data is written, send it to the status strip.
            }

            if (_ToolStripOutput != null)
            {
                try
                {
                    _ToolStripOutput.Text = message; // When character data is written, send it to the status strip.
                }
                catch
                {

                }
            }

            if (!_ProgressForm.Visible)
            { 
                _ProgressForm.Show();
                //_ProgressForm.WindowState = FormWindowState.Minimized;
            }

            _ProgressForm.AddText(message + (char)13 + (char)10);
        }
    }
}
