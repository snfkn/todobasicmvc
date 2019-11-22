using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoBasicMVC.Controller;
using TodoBasicMVC.View;

namespace TodoBasicMVC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (UserView view = new UserView())
            {
                view.Visible = false;

                UserController controller = new UserController(view);
                view.ControllerSet(controller);
                controller.TodoListLoad();

                view.ShowDialog();
            }

        }
    }
}
