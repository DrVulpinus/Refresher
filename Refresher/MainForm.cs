using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refresher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        WindowSwitcher ws;
        Process targetProcess;
        EventHandler eh = new EventHandler();
        private void MainForm_Load(object sender, EventArgs e)
        {
            ws = new WindowSwitcher(this);
            setIntervals();
        }
        private void btn_SetTargetWindow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("After acknowledging this message, please switch to the window you want the events to be sent to.  You will have 5 seconds to select the correct window.  When the window has been selected you will be notified");
            System.Threading.Thread.Sleep(5000);
            targetProcess = ws.getCurrentProcess();
            this.Activate();
            MessageBox.Show("The title bar name of the selected target is: '" + targetProcess.MainWindowTitle + "'.");
        }

        private void btn_GoToTarget_Click(object sender, EventArgs e)
        {
            ws.switchToTarget(targetProcess);
            System.Threading.Thread.Sleep(500);
            ws.returnToOrigin();
        }

        public long getMillisInterval(long hours, long minutes, long seconds)
        {
            long hourSeconds = hours * 3600;
            long minuteSeconds = minutes * 60;
            long output = seconds + minuteSeconds + hourSeconds;
            output *= 1000;
            return output;
        }
        KeysEvent ke;
        private void btn_StartRefreshing_Click(object sender, EventArgs e)
        {
            ke = new KeysEvent(tb_Keys.Text, getMillisInterval((long)nud_Hours.Value, (long)nud_Minutes.Value, (long)nud_Seconds.Value), targetProcess);
            eh.addNewEvent(ke);
            eh.startEvent(ke);
        }

        private void btn_StopRefreshing_Click(object sender, EventArgs e)
        {
            eh.stopEvent(ke);
            eh.removeEvent(ke);
        }

        public void setIntervals()
        {
            if (nud_Seconds.Value == 60)
            {
                nud_Seconds.Minimum = 0;
                nud_Seconds.Value = 0;
                nud_Minutes.Value++;
            }
            if (nud_Minutes.Value == 60)
            {
                nud_Minutes.Value = 0;
                nud_Hours.Value++;
            }
            if (nud_Minutes.Value == 0 && nud_Hours.Value == 0)
            {
                nud_Seconds.Minimum = 1;
            }
            else
            {
                nud_Seconds.Minimum = 0;
            }
        }

        private void nud_Seconds_ValueChanged(object sender, EventArgs e)
        {
            setIntervals();
        }

        private void nud_Minutes_ValueChanged(object sender, EventArgs e)
        {
            setIntervals();
        }

        private void nud_Hours_ValueChanged(object sender, EventArgs e)
        {
            setIntervals();
        }

        private void tb_Keys_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("Entered Text Box");
            tb_Keys.Text = "";
        }

        private void tb_Keys_Leave(object sender, EventArgs e)
        {
            Console.WriteLine("");
            Console.WriteLine("Left Text Box");
        }
        Keys prevKey = Keys.None;
        bool control = false;
        bool shift = false;
        bool alt = false;
        private void tb_Keys_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == prevKey)
            {
                return;
            }
            prevKey = e.KeyCode;
            String key = "";
            switch (e.KeyCode)
            {
                case Keys.Alt:
                    key = "%()";
                    alt = !alt;
                    break;
                case Keys.ShiftKey:
                    key = "+()";
                    shift = !shift;
                    break;
                case Keys.ControlKey:
                    key = "^()";
                    control = !control;
                    break;
                case Keys.Back:
                    key = "{BS}";
                    break;
                case Keys.CapsLock:
                    key = "{CAPSLOCK}";
                    break;
                case Keys.Delete:
                    key = "{DEL}";
                    break;
                case Keys.Divide:
                    key = "{DIVIDE}";
                    break;
                case Keys.Down:
                    key = "{DOWN}";
                    break;
                case Keys.End:
                    key = "{END}";
                    break;
                case Keys.Enter:
                    key = "{ENTER}";
                    break;
                case Keys.Escape:
                    key = "{ESC}";
                    break;
                case Keys.F1:
                    key = "{F1}";
                    break;
                case Keys.F2:
                    key = "{F2}";
                    break;
                case Keys.F3:
                    key = "{F3}";
                    break;
                case Keys.F4:
                    key = "{F4}";
                    break;
                case Keys.F5:
                    key = "{F5}";
                    break;
                case Keys.F6:
                    key = "{F6}";
                    break;
                case Keys.F7:
                    key = "{F7}";
                    break;
                case Keys.F8:
                    key = "{F8}";
                    break;
                case Keys.F9:
                    key = "{F9}";
                    break;
                case Keys.F10:
                    key = "{F10}";
                    break;
                case Keys.F11:
                    key = "{F11}";
                    break;
                case Keys.F12:
                    key = "{F12}";
                    break;
                case Keys.F13:
                    key = "{F13}";
                    break;
                case Keys.F14:
                    key = "{F14}";
                    break;
                case Keys.F15:
                    key = "{F15}";
                    break;
                case Keys.F16:
                    key = "{F16}";
                    break;
                case Keys.Help:
                    key = "{HELP}";
                    break;
                case Keys.Home:
                    key = "{HOME}";
                    break;
                case Keys.Insert:
                    key = "{INSERT}";
                    break;
                case Keys.Left:
                    key = "{LEFT}";
                    break;
                case Keys.Multiply:
                    key = "{MULTIPLY}";
                    break;
                case Keys.NumLock:
                    key = "{NUMLOCK}";
                    break;
                case Keys.PageDown:
                    key = "{PGDN}";
                    break;
                case Keys.PageUp:
                    key = "{PGUP}";
                    break;
                case Keys.Right:
                    key = "{RIGHT}";
                    break;
                case Keys.Scroll:
                    key = "{SCROLLLOCK}";
                    break;
                case Keys.Space:
                    key = " ";
                    break;
                case Keys.Subtract:
                    key = "{SUBTRACT}";
                    break;
                case Keys.Up:
                    key = "{UP}";
                    break;
                case Keys.Tab:
                    key = "{TAB}";
                    break;
                case Keys.D0:
                    key = "0";
                    break;
                case Keys.D1:
                    key = "1";
                    break;
                case Keys.D2:
                    key = "2";
                    break;
                case Keys.D3:
                    key = "3";
                    break;
                case Keys.D4:
                    key = "4";
                    break;
                case Keys.D5:
                    key = "5";
                    break;
                case Keys.D6:
                    key = "6";
                    break;
                case Keys.D7:
                    key = "7";
                    break;
                case Keys.D8:
                    key = "8";
                    break;
                case Keys.D9:
                    key = "9";
                    break;
                case Keys.A:
                    key = "a";
                    break;
                case Keys.B:
                    key = "b";
                    break;
                case Keys.C:
                    key = "c";
                    break;
                case Keys.D:
                    key = "d";
                    break;
                case Keys.E:
                    key = "e";
                    break;
                case Keys.F:
                    key = "f";
                    break;
                case Keys.G:
                    key = "g";
                    break;
                case Keys.H:
                    key = "h";
                    break;
                case Keys.I:
                    key = "i";
                    break;
                case Keys.J:
                    key = "j";
                    break;
                case Keys.K:
                    key = "k";
                    break;
                case Keys.L:
                    key = "l";
                    break;
                case Keys.M:
                    key = "m";
                    break;
                case Keys.N:
                    key = "n";
                    break;
                case Keys.O:
                    key = "o";
                    break;
                case Keys.P:
                    key = "p";
                    break;
                case Keys.Q:
                    key = "q";
                    break;
                case Keys.R:
                    key = "r";
                    break;
                case Keys.S:
                    key = "s";
                    break;
                case Keys.T:
                    key = "t";
                    break;
                case Keys.U:
                    key = "u";
                    break;
                case Keys.V:
                    key = "v";
                    break;
                case Keys.W:
                    key = "w";
                    break;
                case Keys.X:
                    key = "x";
                    break;
                case Keys.Y:
                    key = "y";
                    break;
                case Keys.Z:
                    key = "z";
                    break;
                default:
                    key = "";
                    break;
            }
            updateModifierLabels();
            int cursorPos = tb_Keys.Text.Length;
            
            if (alt && key != "%()")
            {
                cursorPos--;
            }
            else if (!alt && key == "%()")
            {
                return;
            }


            if (shift && key != "+()")
            {
                cursorPos--;
            }
            else if(!shift && key == "+()")
            {
                return;
            }


            if (control && key != "^()")
            {
                cursorPos--;
            }
            else if (!control && key == "^()")
            {
                return;
            }
            

            tb_Keys.Text = tb_Keys.Text.Insert(cursorPos, key);
            
        }

        private void tb_Keys_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void tb_Keys_KeyUp(object sender, KeyEventArgs e)
        {
            prevKey = Keys.None;
        }

        private void updateModifierLabels()
        {
            if (alt)
            {
                lbl_Alt.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                lbl_Alt.BorderStyle = BorderStyle.None;
            }

            if (control)
            {
                lbl_Control.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                lbl_Control.BorderStyle = BorderStyle.None;
            }

            if (shift)
            {
                lbl_Shift.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                lbl_Shift.BorderStyle = BorderStyle.None;
            }
        }

    }
}
