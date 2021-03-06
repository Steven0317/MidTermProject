﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedPortal
{
    /// <summary>
    /// dictirs for south shore
    /// </summary>
    public class SSR
    {
        public string doc1 { get; set; }
        public string doc2 { get; set; }
        public string doc3 { get; set; }
        public string doc4 { get; set; }

        public SSR() { }
        public SSR(string doc1, string doc2, string doc3, string doc4)
        {
            this.doc1 = doc1;
            this.doc2 = doc2;
            this.doc3 = doc3;
            this.doc4 = doc4;
        }
        public string Doctor1 { get { return doc1; } set { doc1 = "Dr. Bogaerts"; } }
        public string Doctor2 { get { return doc2; } set { doc2 = "Dr. Mallov"; } }
        public string Doctor3 { get { return doc3; } set { doc3 = "Dr. Martinez"; } }
        public string Doctor4 { get { return doc4; } set { doc4 = "Dr. Swihart"; } }
    }
}
