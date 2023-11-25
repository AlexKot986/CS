
namespace SeminarCS1
{
    internal class FamilyMambers
    {
        private FamilyMambers wife;
        private FamilyMambers husband;
        private FamilyMambers[] children;
        public string FullName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public FamilyMambers Mother { get; set; }
        public FamilyMambers Father { get; set; }      
        public FamilyMambers Wife 
        { 
            get { return wife; } 
            set { if (Gender is Gender.man) wife = value; }
        }       
        public FamilyMambers Husband 
        { 
            get { return husband; } 
            set { if (Gender is Gender.woman) husband = value; } 
        }       
        public FamilyMambers[] Children 
        {
            get { return children; }
            set { AddChildren(value); } 
        }

        public FamilyMambers[] GetGrandMothers() => new FamilyMambers[] { Mother?.Mother, Father?.Mother };     
        public FamilyMambers[] GetGrandFathers() => new FamilyMambers[] { Mother?.Father, Father?.Father };
        public FamilyMambers GetCloseRelative() => wife ?? husband;
        private void AddChildren(params FamilyMambers[] children) => this.children = children;
    }
}
