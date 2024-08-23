using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDaisyDuck
{
    public delegate void SpeakDelegate(string speak);

    public class Duck
    {
        private string name;
        public event SpeakDelegate speakDel;
        Random rnd = new Random();

        public Duck(String name)
        {
            this.name = name;
        }

        public void StandUp(string sound)
        {
            if (sound.ToLower().Equals("standup"))
            {
                Debug.WriteLine($"{name} I will stand up");
            }
        }

        public void Listening(string sound)
        {
            //Print what the Duck is hearing
            //Debug.WriteLine(this.name + " - " + sound);
            String say = rnd.Next(0, 10) % 2 == 0 ? "Yes" : "No";
            Debug.WriteLine($"{this.name} answers {say} to question: {sound}");
        }

        public void Speak()
        {
            //Print what the Duck is saying
            Debug.WriteLine("Daisy asks a question");
            //this.speakDel?.Invoke("Question (Y/N)");
            if(this.speakDel!=null)
                this.speakDel("Question (Y/N)");
        }
    }
}
