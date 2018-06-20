
namespace domain.Entities
{
    public class Item
    {
        public Item()
        {
            Quantidade = 1;
        }
        
        private int _quantidade;
        public int Quantidade 
        {
             get
             {
                 return _quantidade;
             }
             set
             {
                 if(value < 1) throw new System.Exception();
                 
                _quantidade = value;
             }
        }
    }
}
