using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingKata
{ // You'll need to create a TacoBell class
  // that conforms to ITrackable
    public class TacoBell : ITrackable
    { 
        
        public string Name { get; set; }
        public Point Location { get; set; }
        
    }
        
}
