using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace Refresher
{
    class WindowSwitcher
    {
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        Process targetProcess;
        Process originProcess;
        Form homeForm;
        public WindowSwitcher(Form _homeForm)
        {
            homeForm = _homeForm;
        }
        public void setTarget(Process p)
        {
            targetProcess = p;
        }
        public void switchToTarget(Process p)
        {
            setTarget(p);
            switchToTarget();
        }
        public void switchToTarget()
        {
            originProcess = getCurrentProcess();
            activateApp(targetProcess);
        }
        public void returnToOrigin()
        {
            if (originProcess != null)
            {
                activateApp(originProcess);
                originProcess = null;
            }
        }
        public void switchHome()
        {
            homeForm.Activate();
        }
        public Process[] getRunningProcesses()
        {
            return Process.GetProcesses();
        }

        public Process getCurrentProcess()
        {
             foreach (Process p in Process.GetProcesses())
	            {
                    if (p.MainWindowHandle == GetForegroundWindow())
                    {
                        return p;
                    }
	            }
             return null;
        }
        
        public void activateApp(Process process)
        {
            SetForegroundWindow(process.MainWindowHandle);
        }
        public void activateApp(string processName)
        {
            Process[] p = Process.GetProcessesByName(processName);

            // Activate the first application we find with this name
            if (p.Count() > 0)
                SetForegroundWindow(p[0].MainWindowHandle);
        }
        public void activateApp(int processID)
        {
            Process p = Process.GetProcessById(processID);
           
            // Activate the first application we find with this name
            SetForegroundWindow(p.MainWindowHandle);
        }


    }
}
