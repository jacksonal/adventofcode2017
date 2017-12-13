using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode.Day13
{
    public class SecurityScanner
    {
        private List<FireWallLayer> _layers;

        public IList<FireWallLayer> Layers => _layers;

        private SecurityScanner(string layerDef)
        {
            _layers = new List<FireWallLayer>();
            using (var sr = new StringReader(layerDef))
            {
                var line = sr.ReadLine();
                while (line != null)
                {
                    ParseLayer(line);

                    line = sr.ReadLine();
                }
            }
        }

        private void ParseLayer(string line)
        {
            var parts = line.Split(new[] {':'}, StringSplitOptions.RemoveEmptyEntries);
            var index = Convert.ToInt32(parts[0]);
            //they come to us in order, so fill in the gaps with 0 range layerss
            while (_layers.Count < index)
            {
                _layers.Add(new FireWallLayer());
            }
            var layer = new FireWallLayer();
            layer.ScanRange = Convert.ToInt32(parts[1].Trim());
            _layers.Add(layer);
        }

        public static SecurityScanner CreateModel(string layerDef)
        {
            return new SecurityScanner(layerDef);
        }

        public void Step()
        {
            foreach (var layer in _layers)
            {
                layer.AdvanceScanner();
            }
        }

        public void Reset()
        {
            foreach (var layer in Layers)
            {
                layer.Reset();
            }
        }
    }

    public enum ScanDirection
    {
        Up,
        Down
    }
}