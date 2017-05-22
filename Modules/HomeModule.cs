using Nancy;
using FriendLetter.Objects;

namespace FriendLetter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        LetterVariables myLetterVariables = new LetterVariables();
        myLetterVariables.SetRecipient("Phat");
        myLetterVariables.SetSender("Adrian");
        return View["hello.cshtml", myLetterVariables];
      };
      Get["/form"] = _ => {
        return View["form.cshtml"];
      };
      Get["/greeting_card"] = _ => {
        LetterVariables myLetterVariables = new LetterVariables();
        myLetterVariables.SetRecipient(Request.Query["recipient"]);
        myLetterVariables.SetSender(Request.Query["sender"]);
        myLetterVariables.SetLocation(Request.Query["location"]);
        myLetterVariables.SetSouvenirs(Request.Query["souvenirs"]);
        return View["hello.cshtml", myLetterVariables];
      };
    }
  }
}
