using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dictionary.Models
{
    public class DictionaryModels
    {
        public int  ID { get; set; }

        public string EngItem { get; set; }

	    public string PolItem { get; set; }


	//[PartOfSpeach]
 //       [int] NULL,
	//[LastModification]
 //       [datetime2](7) NULL,
	//[FirstInput]
 //       [datetime2](7) NULL,
	//[Abbreviation]
 //       [nchar](5) NULL,
	//[Branch]
 //       [int] NULL,
	//[TermType]
 //       [int] NULL,
	//[PolItemDef]
 //       [nvarchar](max) NULL,
	//[EngItemDef]
 //       [nvarchar](max) NULL,
	//[Synonyms]
 //       [int] NULL,
	//[Antonyms]
 //       [int] NULL,
	//[TermSuperior]
 //       [int] NULL,
	//[TermInferior]
 //       [int] NULL,
	//[TermAssociated]
 //       [int] NULL,
	//[FalseFriendPL]
 //       [int] NULL,
	//[FalseFriendANG]
 //       [int] NULL,
	//[Image]
 //       [int] NULL,
	//[Colocations]
 //       [int] NULL,
	//[Examples]
 //       [nvarchar](max) NULL,
	//[Occurence]
 //       [int] NULL,
	//[AdditionalInfo]
 //       [nvarchar](max) NULL
    }
}