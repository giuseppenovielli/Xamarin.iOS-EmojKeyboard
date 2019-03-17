using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace XamAGEmojiKeyboard
{
	// @interface AGEmojiKeyboardView : UIView
	[BaseType (typeof(UIView))]
	interface AGEmojiKeyboardView
	{
		// @property (readonly, nonatomic) UISegmentedControl * segmentsBar;
		[Export ("segmentsBar")]
		UISegmentedControl SegmentsBar { get; }

		// @property (readonly, nonatomic) UIPageControl * pageControl;
		[Export ("pageControl")]
		UIPageControl PageControl { get; }

		// @property (readonly, nonatomic) UIScrollView * emojiPagesScrollView;
		[Export ("emojiPagesScrollView")]
		UIScrollView EmojiPagesScrollView { get; }

		[Wrap ("WeakDelegate")]
		AGEmojiKeyboardViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<AGEmojiKeyboardViewDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) id<AGEmojiKeyboardViewDataSource> dataSource;
		[Export ("dataSource", ArgumentSemantic.Weak)]
		AGEmojiKeyboardViewDataSource DataSource { get; set; }

		// -(instancetype)initWithFrame:(CGRect)frame dataSource:(id<AGEmojiKeyboardViewDataSource>)dataSource;
		[Export ("initWithFrame:dataSource:")]
		IntPtr Constructor (CGRect frame, AGEmojiKeyboardViewDataSource dataSource);
	}

	// @protocol AGEmojiKeyboardViewDataSource <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface AGEmojiKeyboardViewDataSource
	{
		// @required -(UIImage *)emojiKeyboardView:(AGEmojiKeyboardView *)emojiKeyboardView imageForSelectedCategory:(AGEmojiKeyboardViewCategoryImage)category;
		[Abstract]
		[Export ("emojiKeyboardView:imageForSelectedCategory:")]
		UIImage EmojiKeyboardView (AGEmojiKeyboardView emojiKeyboardView, AGEmojiKeyboardViewCategoryImage category);

		// @required -(UIImage *)emojiKeyboardViewNonSelected:(AGEmojiKeyboardView *)emojiKeyboardView imageForNonSelectedCategory:(AGEmojiKeyboardViewCategoryImage)category;
		[Abstract]
		[Export ("emojiKeyboardViewNonSelected:imageForNonSelectedCategory:")]
		UIImage EmojiKeyboardViewNonSelected (AGEmojiKeyboardView emojiKeyboardView, AGEmojiKeyboardViewCategoryImage category);

		// @required -(UIImage *)backSpaceButtonImageForEmojiKeyboardView:(AGEmojiKeyboardView *)emojiKeyboardView;
		[Abstract]
		[Export ("backSpaceButtonImageForEmojiKeyboardView:")]
		UIImage BackSpaceButtonImageForEmojiKeyboardView (AGEmojiKeyboardView emojiKeyboardView);

		// @optional -(AGEmojiKeyboardViewCategoryImage)defaultCategoryForEmojiKeyboardView:(AGEmojiKeyboardView *)emojiKeyboardView;
		[Export ("defaultCategoryForEmojiKeyboardView:")]
		AGEmojiKeyboardViewCategoryImage DefaultCategoryForEmojiKeyboardView (AGEmojiKeyboardView emojiKeyboardView);

		// @optional -(NSUInteger)recentEmojisMaintainedCountForEmojiKeyboardView:(AGEmojiKeyboardView *)emojiKeyboardView;
		[Export ("recentEmojisMaintainedCountForEmojiKeyboardView:")]
		nuint RecentEmojisMaintainedCountForEmojiKeyboardView (AGEmojiKeyboardView emojiKeyboardView);
	}

	// @protocol AGEmojiKeyboardViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface AGEmojiKeyboardViewDelegate
	{
		// @required -(void)emojiKeyBoardView:(AGEmojiKeyboardView *)emojiKeyBoardView didUseEmoji:(NSString *)emoji;
		[Abstract]
		[Export ("emojiKeyBoardView:didUseEmoji:")]
		void EmojiKeyBoardView (AGEmojiKeyboardView emojiKeyBoardView, string emoji);

		// @required -(void)emojiKeyBoardViewDidPressBackSpace:(AGEmojiKeyboardView *)emojiKeyBoardView;
		[Abstract]
		[Export ("emojiKeyBoardViewDidPressBackSpace:")]
		void EmojiKeyBoardViewDidPressBackSpace (AGEmojiKeyboardView emojiKeyBoardView);
	}

	// @interface AGEmojiPageView : UIView
	[BaseType (typeof(UIView))]
	interface AGEmojiPageView
	{
		[Wrap ("WeakDelegate")]
		AGEmojiPageViewDelegate Delegate { get; set; }

		// @property (assign, nonatomic) id<AGEmojiPageViewDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Assign)]
		NSObject WeakDelegate { get; set; }

		// -(id)initWithFrame:(CGRect)frame backSpaceButtonImage:(UIImage *)backSpaceButtonImage buttonSize:(CGSize)buttonSize rows:(NSUInteger)rows columns:(NSUInteger)columns;
		[Export ("initWithFrame:backSpaceButtonImage:buttonSize:rows:columns:")]
		IntPtr Constructor (CGRect frame, UIImage backSpaceButtonImage, CGSize buttonSize, nuint rows, nuint columns);

		// -(void)setButtonTexts:(NSMutableArray *)buttonTexts;
		[Export ("setButtonTexts:")]
		void SetButtonTexts (NSMutableArray buttonTexts);
	}

	// @protocol AGEmojiPageViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface AGEmojiPageViewDelegate
	{
		// @required -(void)emojiPageView:(AGEmojiPageView *)emojiPageView didUseEmoji:(NSString *)emoji;
		[Abstract]
		[Export ("emojiPageView:didUseEmoji:")]
		void EmojiPageView (AGEmojiPageView emojiPageView, string emoji);

		// @required -(void)emojiPageViewDidPressBackSpace:(AGEmojiPageView *)emojiPageView;
		[Abstract]
		[Export ("emojiPageViewDidPressBackSpace:")]
		void EmojiPageViewDidPressBackSpace (AGEmojiPageView emojiPageView);
	}
}
