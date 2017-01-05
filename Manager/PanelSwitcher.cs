using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Manager
{
    class PanelSwitcher
    {
        Panel[] Panels;


        private Panel _ActivePanel;

        public Panel ActivePanel
        {
            get { return _ActivePanel; }
            set { 
                _ActivePanel = value;
                Show(_ActivePanel);
            }
        }


        private void HideAll()
        {
            foreach (Panel panel in Panels)
            {
                panel.Visible = false;
            }
        }

        public PanelSwitcher(Panel[] panels)
        {
            Panels = panels;

            HideAll();

            _ActivePanel = panels[0];
            _ActivePanel.Visible = true;



        }
        public void Show(Panel panelToShow)
        {
            foreach (Panel panel in Panels)
            {
                Console.WriteLine(panel.Name);
                if (panel.Equals(panelToShow))
                {
                    HideAll();
                    _ActivePanel = panel;
                    _ActivePanel.Visible = true;
                    return;
                }

                    
            }
        }



    }
}
