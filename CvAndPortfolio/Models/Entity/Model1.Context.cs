﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CvAndPortfolio.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PortfolioAndCvEntities2 : DbContext
    {
        public PortfolioAndCvEntities2()
            : base("name=PortfolioAndCvEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TBLCATEGORY> TBLCATEGORies { get; set; }
        public virtual DbSet<TBLCERTIFICATE> TBLCERTIFICATEs { get; set; }
        public virtual DbSet<TBLEDUCATION> TBLEDUCATIONs { get; set; }
        public virtual DbSet<TBLEXPERIENCE> TBLEXPERIENCEs { get; set; }
        public virtual DbSet<TBLFACT> TBLFACTs { get; set; }
        public virtual DbSet<TBLFACTDESCRIPTION> TBLFACTDESCRIPTIONs { get; set; }
        public virtual DbSet<TBLPORTFOLIO> TBLPORTFOLIOs { get; set; }
        public virtual DbSet<TBLRESUME> TBLRESUMEs { get; set; }
        public virtual DbSet<TBLSKILL> TBLSKILLs { get; set; }
        public virtual DbSet<TBLSOCIALMEDIA> TBLSOCIALMEDIAs { get; set; }
        public virtual DbSet<TBLSTUDY> TBLSTUDies { get; set; }
        public virtual DbSet<TBLSTUDYPIC> TBLSTUDYPICs { get; set; }
        public virtual DbSet<TBLABOUT> TBLABOUTs { get; set; }
        public virtual DbSet<TBLCONTACT> TBLCONTACTs { get; set; }
    }
}
