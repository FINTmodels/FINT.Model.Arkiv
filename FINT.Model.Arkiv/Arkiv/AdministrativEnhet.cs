// Built from tag arkiv

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Arkiv
{
	public class AdministrativEnhet {
		public enum Relasjonsnavn
        {
			ORGANISASJONSELEMENT
        }
        
	
		public Periode Gyldighetsperiode { get; set; }
		public string Navn { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}
