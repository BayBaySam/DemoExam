//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoExam
{
    using System;
    using System.Collections.Generic;
    
    public partial class Postavki
    {
        public int ID { get; set; }
        public int IDMaterial { get; set; }
        public int IDPostavshik { get; set; }

        public string Name
        {
            get
            {
                return Material.Name;
            }
        }
        public int MinKol
        {
            get
            {
                return Material.MinKol;
            }
        }
        public int CurrKol
        {
            get
            {
                return Material.KolVoNaSklad;
            }
        }
        public string MatTip
        {
            get
            {
                return Material.MatTip;
            }
        }
        public int Tip
        {
            get
            {
                return Material.TipMaterial.ID;
            }
        }
        public string Ed
        {
            get
            {
                return Material.Ed;
            }
        }
        public string Post
        {
            get
            {
                return Postavshiki.Name;
            }
        }

        public virtual Material Material { get; set; }
        public virtual Postavshiki Postavshiki { get; set; }
    }
}
