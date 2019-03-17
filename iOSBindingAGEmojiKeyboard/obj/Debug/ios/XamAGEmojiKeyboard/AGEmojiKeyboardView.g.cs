//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;

namespace XamAGEmojiKeyboard {
	[Register("AGEmojiKeyboardView", true)]
	public unsafe partial class AGEmojiKeyboardView : global::UIKit.UIView {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("AGEmojiKeyboardView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AGEmojiKeyboardView () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public AGEmojiKeyboardView (NSCoder coder) : base (NSObjectFlag.Empty)
		{

			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected AGEmojiKeyboardView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AGEmojiKeyboardView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithFrame:dataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AGEmojiKeyboardView (CGRect frame, AGEmojiKeyboardViewDataSource dataSource)
			: base (NSObjectFlag.Empty)
		{
			if (dataSource == null)
				throw new ArgumentNullException ("dataSource");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_CGRect_IntPtr (this.Handle, Selector.GetHandle ("initWithFrame:dataSource:"), frame, dataSource.Handle), "initWithFrame:dataSource:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithFrame:dataSource:"), frame, dataSource.Handle), "initWithFrame:dataSource:");
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_DataSource_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AGEmojiKeyboardViewDataSource DataSource {
			[Export ("dataSource", ArgumentSemantic.Weak)]
			get {
				AGEmojiKeyboardViewDataSource ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AGEmojiKeyboardViewDataSource> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dataSource")));
				} else {
					ret =  Runtime.GetNSObject<AGEmojiKeyboardViewDataSource> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dataSource")));
				}
				MarkDirty ();
				__mt_DataSource_var = ret;
				return ret;
			}
			
			[Export ("setDataSource:", ArgumentSemantic.Weak)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDataSource:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDataSource:"), value.Handle);
				}
				MarkDirty ();
				__mt_DataSource_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AGEmojiKeyboardViewDelegate Delegate {
			get {
				return WeakDelegate as AGEmojiKeyboardViewDelegate;
			}
			set {
				var rvalue = value as NSObject;
				if (value != null && rvalue == null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIScrollView EmojiPagesScrollView {
			[Export ("emojiPagesScrollView")]
			get {
				global::UIKit.UIScrollView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIScrollView> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("emojiPagesScrollView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIScrollView> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("emojiPagesScrollView")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIPageControl PageControl {
			[Export ("pageControl")]
			get {
				global::UIKit.UIPageControl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIPageControl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("pageControl")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIPageControl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pageControl")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UISegmentedControl SegmentsBar {
			[Export ("segmentsBar")]
			get {
				global::UIKit.UISegmentedControl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UISegmentedControl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("segmentsBar")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UISegmentedControl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("segmentsBar")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_DataSource_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
		public partial class AGEmojiKeyboardViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal AGEmojiKeyboardViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new AGEmojiKeyboardViewAppearance Appearance {
			get { return new AGEmojiKeyboardViewAppearance (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new AGEmojiKeyboardViewAppearance GetAppearance<T> () where T: AGEmojiKeyboardView {
			return new AGEmojiKeyboardViewAppearance (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new AGEmojiKeyboardViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new AGEmojiKeyboardViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new AGEmojiKeyboardViewAppearance GetAppearance (UITraitCollection traits) {
			return new AGEmojiKeyboardViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new AGEmojiKeyboardViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new AGEmojiKeyboardViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new AGEmojiKeyboardViewAppearance GetAppearance<T> (UITraitCollection traits) where T: AGEmojiKeyboardView {
			return new AGEmojiKeyboardViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new AGEmojiKeyboardViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: AGEmojiKeyboardView{
			return new AGEmojiKeyboardViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class AGEmojiKeyboardView */
}
