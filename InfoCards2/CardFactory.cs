using System;

namespace Assignment
{
    public class CardFactory : IInfoCardFactory
    {
        public string[] Catsupp = { "CreditCard", "GiftCard", "Image" };
        public string[] CategoriesSupported => Catsupp; 


        public IInfoCard CreateInfoCard(string initialDetails)
        {
            string[] splitID = initialDetails.Split('|');       //splits string from the txt file to determine the object category when loading
            
            switch (splitID[0])
            {
                case "CreditCard":  return new CreditCard(initialDetails);
                    
                case "GiftCard": return new GiftCard(initialDetails);

                case "Image": return new B64Image(initialDetails);

                default: throw new NotImplementedException();   //throws exeption if the txt files is messed with
            }
        }

        public IInfoCard CreateNewInfoCard(string category)
        {
            switch (category)                                   //determins what object to create when creating a new object
            {
                case "CreditCard": return new CreditCard();

                case "GiftCard": return new GiftCard();

                case "Image": return new B64Image();

                default: throw new NotImplementedException();   //throws exeption if the txt files is messed with
            }
        }

        public string GetDescription(string category)
        {
            switch (category)                                   //adds description to the create form
            {
                case "CreditCard": return "Stores a Credit Cards Information";

                case "GiftCard": return "Stores a Gift Cards Information";

                case "Image": return "Stores an Image";

                default: throw new NotImplementedException();   //throws exeption if the txt files is messed with
            }
        }
    }
}
