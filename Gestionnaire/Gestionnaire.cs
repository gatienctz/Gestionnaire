using System;
using System.Windows.Forms;
using Gestionnaire.model;

namespace Gestionnaire
{
    public partial class Gestionnaire : Form
    {
        private Profil user;
        
        public Gestionnaire(Profil p)
        {
            InitializeComponent();
            user = p;
        }
    }
}