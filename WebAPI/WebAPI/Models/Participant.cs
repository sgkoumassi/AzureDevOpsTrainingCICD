//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Participant
    {
        public int ParticipantID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Nullable<int> Score { get; set; }
        public Nullable<int> TimeSpent { get; set; }
    }
}
