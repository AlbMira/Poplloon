using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Poplloon.Entity;
using Poplloon.main;
using TMPro;

namespace Poplloon.Attributes
{
    public class ColorData
    {
        public Dictionary<string, Color> _colorData = new Dictionary<string, Color>();
        //Get color at index position
        public Color GetColor(int index) => _colorData.Values.ToArray()[index];
        //Return a random color
        public Color GetColor()
        {
            int index = UnityEngine.Random.Range(0, _colorData.Values.Count);

            return GetColor(index);
        }

        //Return KeyValuePair by name from ColorData
        public KeyValuePair<string, Color> GetPair(string _name) => _colorData.First(i => i.Key == _name);
        //Return KeyValuePair by color from ColorData
        public KeyValuePair<string, Color> GetPair(Color _color) => _colorData.First(i => i.Value == _color);
        //Return KeyValuePair by index position from ColorData
        public KeyValuePair<string, Color> GetPair(int index) => _colorData.First(i => i.Value == GetColor(index));
        //Return randomless KeyValuePair from ColorData
        public KeyValuePair<string, Color> GetPair()
        {
            //Return a random color
            var _color = GetColor();

            return _colorData.First(i => i.Value == _color);
        }

        //Set ColorData from a input
        public void SetColor(Dictionary<string, Color> _data) => _colorData = _data;
        //Add Data input data into ColorData
        public void AddColor(KeyValuePair<string, Color> _data) => _colorData.Add(_data.Key, _data.Value);
    }

    public class ColorDataSet : MonoBehaviour
    {
        public Dictionary<string, ColorData> _dataSet = new Dictionary<string, ColorData>();
        public ColorData _current;
        public TMPro.TextMeshProUGUI _label;

        //DataSets, it sets the color blind filters 
        public void SetColorSet()
        {
            AddColorSet("none", new KeyValuePair<string, Color>[] { new KeyValuePair<string, Color>("Red", Color.red),
                                                       new KeyValuePair<string, Color>("Blue", Color.blue),
                                                       new KeyValuePair<string, Color>("Green", Color.green),
                                                       new KeyValuePair<string, Color>("Yellow", Color.yellow)});
            AddColorSet("deuteranopia", new KeyValuePair<string, Color>[] { new KeyValuePair<string, Color>("Red", Color.red),
                                                       new KeyValuePair<string, Color>("Blue", Color.blue),
                                                       new KeyValuePair<string, Color>("Green", new Color(0, 0.1f, 0, 1)),
                                                       new KeyValuePair<string, Color>("Yellow", new Color(1, 0.3f, 0, 1))});
            AddColorSet("protanopia", new KeyValuePair<string, Color>[] { new KeyValuePair<string, Color>("Red", new Color(0.5f, 0.2f, 0.2f, 1)),
                                                       new KeyValuePair<string, Color>("Blue", new Color(0.2f, 0.2f, 0.5f, 1)),
                                                       new KeyValuePair<string, Color>("Green", new Color(0.2f, 0.5f, 0.2f, 1)),
                                                       new KeyValuePair<string, Color>("Yellow", new Color(0.5f, 0.5f, 0.2f, 1))});
            AddColorSet("tritanopia", new KeyValuePair<string, Color>[] { new KeyValuePair<string, Color>("Red", Color.red),
                                                       new KeyValuePair<string, Color>("Blue", new Color(0, 0.3058824f, 0.3176471f, 1)),
                                                       new KeyValuePair<string, Color>("Green", new Color(0.4117647f, 0.8627451f, 0.9294118f, 1)),
                                                       new KeyValuePair<string, Color>("Yellow", new Color(0.972549f, 0.8901961f, 0.9019608f, 1))});
            AddColorSet("acromatopsia", new KeyValuePair<string, Color>[] { new KeyValuePair<string, Color>("Red", new Color(0.6117647f, 0.6117647f, 0.6117647f, 1)),
                                                       new KeyValuePair<string, Color>("Blue", new Color(0.3137255f, 0.3137255f, 0.3137255f, 1)),
                                                       new KeyValuePair<string, Color>("Green", new Color(0.4117647f, 0.8627451f, 0.9294118f, 1)),
                                                       new KeyValuePair<string, Color>("Yellow", new Color(0.5f, 0.5f, 0.2f, 1))});

            _current = _dataSet[SetFilterController.colorBlindFilters[MainMenuController.indexFilter]];
        }

        //Adding new ColorData to data set
        public void AddColorSet(string _name, KeyValuePair<string, Color>[] _arr)
        {
            var _data = new ColorData();
            foreach (var e in _arr)
            {
                _data.AddColor(e);
            }
            _dataSet.Add(_name, _data);
        }
    }
}


