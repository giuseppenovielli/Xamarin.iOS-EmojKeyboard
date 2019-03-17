# Xamarin.iOS-EmojKeyboard
Xamarin.iOS Binding of AGEmojiKeyboard library https://github.com/ayushgoel/AGEmojiKeyboard by Giuseppe Novielli

# Inizialize EmojiKeyboard

using XamAGEmojiKeyboard;

namespace Example.iOS
{

  public partial class EmojiKeyboardViewController : UIViewController
  {
    .....
    AGEmojiKeyboardView _emojiView;
    .......
    
     public override void ViewDidLoad()
     {
            base.ViewDidLoad();
            
            ......
            
             var cgRect = new CGRect(0,0, View.Frame.Size.Width, 216);
            
            //Inizialize KeyboardEmoji with DataSource
            _emojiView = new AGEmojiKeyboardView(cgRect, new EmojiKeyDataSource());
            _emojiView.AutoresizingMask = UIViewAutoresizing.FlexibleHeight;
            
            //Inizialize Delegate
            var emojiDelegate = new EmojiKeyDelegate();
            emojiDelegate.OnEmojiSelected += EmojiDelegate_OnEmojiSelected;
            emojiDelegate.OnEmojiDeleted += EmojiDelegate_OnEmojiDeleted;
            
            //Set Delegate
            _emojiView.Delegate = emojiDelegate;
            
            
            .......
            
     }
    
   }

}


# DataSource Class
using XamAGEmojiKeyboard;

namespace Example.iOS
{
    public class EmojiKeyDataSource : AGEmojiKeyboardViewDataSource
    {
        public EmojiKeyDataSource()
        {
        }

        public override UIImage BackSpaceButtonImageForEmojiKeyboardView(AGEmojiKeyboardView emojiKeyboardView)
        {
            //Return UIImage 
        }

        public override UIImage EmojiKeyboardView(AGEmojiKeyboardView emojiKeyboardView, AGEmojiKeyboardViewCategoryImage category)
        {
          //Return UIImage 

        }

        public override UIImage EmojiKeyboardViewNonSelected(AGEmojiKeyboardView emojiKeyboardView, AGEmojiKeyboardViewCategoryImage category)
        {
            //Return UIImage 

        }
    }
}

# Delegate Class

using XamAGEmojiKeyboard;

namespace Example.iOS
{
    public class EmojiKeyDelegate : AGEmojiKeyboardViewDelegate
    {
        public event EventHandler<string> OnEmojiSelected;
        public event EventHandler OnEmojiDeleted;


        public EmojiKeyDelegate()
        {
        }

        public override void EmojiKeyBoardView(AGEmojiKeyboardView emojiKeyBoardView, string emoji)
        {
            OnEmojiSelected?.Invoke(emojiKeyBoardView, emoji);
        }

        public override void EmojiKeyBoardViewDidPressBackSpace(AGEmojiKeyboardView emojiKeyBoardView)
        {
            OnEmojiDeleted?.Invoke(emojiKeyBoardView, EventArgs.Empty);
        }
    }

More Documentation Available https://github.com/ayushgoel/AGEmojiKeyboard
