namespace BlazorSchulungV8.Components.Pages.Modul4
{
    public class ChatVM
    {
        public  Action OnAdd;
       // public event Action OnAdd;

        public List<ChatModel> Liste { get; set; } = new List<ChatModel>();
        public void Add(string msg)
        {
            Liste.Add(new ChatModel() { Nachricht = msg });
            OnAdd?.Invoke();
        }
    }
}
