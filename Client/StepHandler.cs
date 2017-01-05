using System.Collections.Generic;
using ComponentFactory.Krypton.Toolkit;

public class StepHandler
{

    List<KryptonPanel> StepPanel = new List<KryptonPanel>();

    public StepHandler( KryptonPanel[] stepPanels)
    {
       foreach (KryptonPanel panel in stepPanels)
        {
            StepPanel.Add(panel);
            panel.Hide();
        }
    }

    public void Show(KryptonPanel panelToShow)
    {

        foreach ( KryptonPanel panel in StepPanel) {
            if (panel.Equals(panelToShow)) {
                panel.Show();
                panel.Refresh();
            }
            else {
                panel.Hide();
            }
        }
        
    }




}
