using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace materialEstimatorCondensed
{
    public class MaterialSelection
    {
        public string Category { get; set; }
        public string Item { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public double Cost { get; set; }
        public int Quantity { get; set; }

        // Generate estimate
        public void generateEstimate(string category, string item, string description, string size, double cost, int quantity)
        {
            MaterialSelection selection = new MaterialSelection();
            selection.Category = category;
            selection.Item = item;
            selection.Description = description;
            selection.Size = size;
            selection.Cost = Convert.ToDouble(cost);
            selection.Quantity = Convert.ToInt32(quantity);

            EstimateList.CreatedEstimates.Add(selection);
        }

        // if object is selected
        public List<string> ObjectSelection(string selectedItem)
        {
            List<string> selected = selectedItem.Split("  ").ToList();

            List<string> finalSelected = selected.Where(x => x != "" && x != "|" && x != " |").ToList();

            return finalSelected;
        }
    }
}
