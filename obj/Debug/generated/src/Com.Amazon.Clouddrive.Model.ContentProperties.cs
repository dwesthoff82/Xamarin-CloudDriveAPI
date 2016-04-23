using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ContentProperties']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/ContentProperties", DoNotGenerateAcw=true)]
	public partial class ContentProperties : global::Java.Lang.Object, global::Java.Lang.IComparable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/ContentProperties", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContentProperties); }
		}

		protected ContentProperties (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ContentProperties']/constructor[@name='ContentProperties' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ContentProperties ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ContentProperties)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getContentDate;
#pragma warning disable 0169
		static Delegate GetGetContentDateHandler ()
		{
			if (cb_getContentDate == null)
				cb_getContentDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentDate);
			return cb_getContentDate;
		}

		static IntPtr n_GetContentDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ContentProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentDate);
		}
#pragma warning restore 0169

		static Delegate cb_setContentDate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentDate_Ljava_lang_String_Handler ()
		{
			if (cb_setContentDate_Ljava_lang_String_ == null)
				cb_setContentDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentDate_Ljava_lang_String_);
			return cb_setContentDate_Ljava_lang_String_;
		}

		static void n_SetContentDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ContentProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ContentDate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContentDate;
		static IntPtr id_setContentDate_Ljava_lang_String_;
		public virtual unsafe string ContentDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ContentProperties']/method[@name='getContentDate' and count(parameter)=0]"
			[Register ("getContentDate", "()Ljava/lang/String;", "GetGetContentDateHandler")]
			get {
				if (id_getContentDate == IntPtr.Zero)
					id_getContentDate = JNIEnv.GetMethodID (class_ref, "getContentDate", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getContentDate), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentDate", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ContentProperties']/method[@name='setContentDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContentDate", "(Ljava/lang/String;)V", "GetSetContentDate_Ljava_lang_String_Handler")]
			set {
				if (id_setContentDate_Ljava_lang_String_ == IntPtr.Zero)
					id_setContentDate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContentDate", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setContentDate_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContentDate", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getContentType;
#pragma warning disable 0169
		static Delegate GetGetContentTypeHandler ()
		{
			if (cb_getContentType == null)
				cb_getContentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentType);
			return cb_getContentType;
		}

		static IntPtr n_GetContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ContentProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentType);
		}
#pragma warning restore 0169

		static Delegate cb_setContentType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentType_Ljava_lang_String_Handler ()
		{
			if (cb_setContentType_Ljava_lang_String_ == null)
				cb_setContentType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentType_Ljava_lang_String_);
			return cb_setContentType_Ljava_lang_String_;
		}

		static void n_SetContentType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ContentProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ContentType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContentType;
		static IntPtr id_setContentType_Ljava_lang_String_;
		public virtual unsafe string ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ContentProperties']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Ljava/lang/String;", "GetGetContentTypeHandler")]
			get {
				if (id_getContentType == IntPtr.Zero)
					id_getContentType = JNIEnv.GetMethodID (class_ref, "getContentType", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getContentType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ContentProperties']/method[@name='setContentType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContentType", "(Ljava/lang/String;)V", "GetSetContentType_Ljava_lang_String_Handler")]
			set {
				if (id_setContentType_Ljava_lang_String_ == IntPtr.Zero)
					id_setContentType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContentType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setContentType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContentType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDocument;
#pragma warning disable 0169
		static Delegate GetGetDocumentHandler ()
		{
			if (cb_getDocument == null)
				cb_getDocument = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDocument);
			return cb_getDocument;
		}

		static IntPtr n_GetDocument (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ContentProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Document);
		}
#pragma warning restore 0169

		static Delegate cb_setDocument_Lcom_amazon_clouddrive_model_DocumentProperties_;
#pragma warning disable 0169
		static Delegate GetSetDocument_Lcom_amazon_clouddrive_model_DocumentProperties_Handler ()
		{
			if (cb_setDocument_Lcom_amazon_clouddrive_model_DocumentProperties_ == null)
				cb_setDocument_Lcom_amazon_clouddrive_model_DocumentProperties_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDocument_Lcom_amazon_clouddrive_model_DocumentProperties_);
			return cb_setDocument_Lcom_amazon_clouddrive_model_DocumentProperties_;
		}

		static void n_SetDocument_Lcom_amazon_clouddrive_model_DocumentProperties_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ContentProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.DocumentProperties p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DocumentProperties> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Document = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDocument;
		static IntPtr id_setDocument_Lcom_amazon_clouddrive_model_DocumentProperties_;
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.DocumentProperties Document {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ContentProperties']/method[@name='getDocument' and count(parameter)=0]"
			[Register ("getDocument", "()Lcom/amazon/clouddrive/model/DocumentProperties;", "GetGetDocumentHandler")]
			get {
				if (id_getDocument == IntPtr.Zero)
					id_getDocument = JNIEnv.GetMethodID (class_ref, "getDocument", "()Lcom/amazon/clouddrive/model/DocumentProperties;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DocumentProperties> (JNIEnv.CallObjectMethod  (Handle, id_getDocument), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DocumentProperties> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDocument", "()Lcom/amazon/clouddrive/model/DocumentProperties;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ContentProperties']/method[@name='setDocument' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.DocumentProperties']]"
			[Register ("setDocument", "(Lcom/amazon/clouddrive/model/DocumentProperties;)V", "GetSetDocument_Lcom_amazon_clouddrive_model_DocumentProperties_Handler")]
			set {
				if (id_setDocument_Lcom_amazon_clouddrive_model_DocumentProperties_ == IntPtr.Zero)
					id_setDocument_Lcom_amazon_clouddrive_model_DocumentProperties_ = JNIEnv.GetMethodID (class_ref, "setDocument", "(Lcom/amazon/clouddrive/model/DocumentProperties;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDocument_Lcom_amazon_clouddrive_model_DocumentProperties_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDocument", "(Lcom/amazon/clouddrive/model/DocumentProperties;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getExtension;
#pragma warning disable 0169
		static Delegate GetGetExtensionHandler ()
		{
			if (cb_getExtension == null)
				cb_getExtension = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtension);
			return cb_getExtension;
		}

		static IntPtr n_GetExtension (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ContentProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Extension);
		}
#pragma warning restore 0169

		static Delegate cb_setExtension_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetExtension_Ljava_lang_String_Handler ()
		{
			if (cb_setExtension_Ljava_lang_String_ == null)
				cb_setExtension_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExtension_Ljava_lang_String_);
			return cb_setExtension_Ljava_lang_String_;
		}

		static void n_SetExtension_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ContentProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Extension = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExtension;
		static IntPtr id_setExtension_Ljava_lang_String_;
		public virtual unsafe string Extension {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ContentProperties']/method[@name='getExtension' and count(parameter)=0]"
			[Register ("getExtension", "()Ljava/lang/String;", "GetGetExtensionHandler")]
			get {
				if (id_getExtension == IntPtr.Zero)
					id_getExtension = JNIEnv.GetMethodID (class_ref, "getExtension", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getExtension), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExtension", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ContentProperties']/method[@name='setExtension' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setExtension", "(Ljava/lang/String;)V", "GetSetExtension_Ljava_lang_String_Handler")]
			set {
				if (id_setExtension_Ljava_lang_String_ == IntPtr.Zero)
					id_setExtension_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setExtension", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setExtension_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExtension", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getImage;
#pragma warning disable 0169
		static Delegate GetGetImageHandler ()
		{
			if (cb_getImage == null)
				cb_getImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImage);
			return cb_getImage;
		}

		static IntPtr n_GetImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ContentProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Image);
		}
#pragma warning restore 0169

		static Delegate cb_setImage_Lcom_amazon_clouddrive_model_ImageProperties_;
#pragma warning disable 0169
		static Delegate GetSetImage_Lcom_amazon_clouddrive_model_ImageProperties_Handler ()
		{
			if (cb_setImage_Lcom_amazon_clouddrive_model_ImageProperties_ == null)
				cb_setImage_Lcom_amazon_clouddrive_model_ImageProperties_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImage_Lcom_amazon_clouddrive_model_ImageProperties_);
			return cb_setImage_Lcom_amazon_clouddrive_model_ImageProperties_;
		}

		static void n_SetImage_Lcom_amazon_clouddrive_model_ImageProperties_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ContentProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ImageProperties p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Image = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImage;
		static IntPtr id_setImage_Lcom_amazon_clouddrive_model_ImageProperties_;
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.ImageProperties Image {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ContentProperties']/method[@name='getImage' and count(parameter)=0]"
			[Register ("getImage", "()Lcom/amazon/clouddrive/model/ImageProperties;", "GetGetImageHandler")]
			get {
				if (id_getImage == IntPtr.Zero)
					id_getImage = JNIEnv.GetMethodID (class_ref, "getImage", "()Lcom/amazon/clouddrive/model/ImageProperties;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (JNIEnv.CallObjectMethod  (Handle, id_getImage), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImage", "()Lcom/amazon/clouddrive/model/ImageProperties;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ContentProperties']/method[@name='setImage' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.ImageProperties']]"
			[Register ("setImage", "(Lcom/amazon/clouddrive/model/ImageProperties;)V", "GetSetImage_Lcom_amazon_clouddrive_model_ImageProperties_Handler")]
			set {
				if (id_setImage_Lcom_amazon_clouddrive_model_ImageProperties_ == IntPtr.Zero)
					id_setImage_Lcom_amazon_clouddrive_model_ImageProperties_ = JNIEnv.GetMethodID (class_ref, "setImage", "(Lcom/amazon/clouddrive/model/ImageProperties;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setImage_Lcom_amazon_clouddrive_model_ImageProperties_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImage", "(Lcom/amazon/clouddrive/model/ImageProperties;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMd5;
#pragma warning disable 0169
		static Delegate GetGetMd5Handler ()
		{
			if (cb_getMd5 == null)
				cb_getMd5 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMd5);
			return cb_getMd5;
		}

		static IntPtr n_GetMd5 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ContentProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Md5);
		}
#pragma warning restore 0169

		static Delegate cb_setMd5_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMd5_Ljava_lang_String_Handler ()
		{
			if (cb_setMd5_Ljava_lang_String_ == null)
				cb_setMd5_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMd5_Ljava_lang_String_);
			return cb_setMd5_Ljava_lang_String_;
		}

		static void n_SetMd5_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ContentProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Md5 = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMd5;
		static IntPtr id_setMd5_Ljava_lang_String_;
		public virtual unsafe string Md5 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ContentProperties']/method[@name='getMd5' and count(parameter)=0]"
			[Register ("getMd5", "()Ljava/lang/String;", "GetGetMd5Handler")]
			get {
				if (id_getMd5 == IntPtr.Zero)
					id_getMd5 = JNIEnv.GetMethodID (class_ref, "getMd5", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMd5), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMd5", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ContentProperties']/method[@name='setMd5' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMd5", "(Ljava/lang/String;)V", "GetSetMd5_Ljava_lang_String_Handler")]
			set {
				if (id_setMd5_Ljava_lang_String_ == IntPtr.Zero)
					id_setMd5_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMd5", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMd5_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMd5", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSize);
			return cb_getSize;
		}

		static IntPtr n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ContentProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Size);
		}
#pragma warning restore 0169

		static Delegate cb_setSize_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetSize_Ljava_lang_Long_Handler ()
		{
			if (cb_setSize_Ljava_lang_Long_ == null)
				cb_setSize_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSize_Ljava_lang_Long_);
			return cb_setSize_Ljava_lang_Long_;
		}

		static void n_SetSize_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ContentProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Size = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSize;
		static IntPtr id_setSize_Ljava_lang_Long_;
		public virtual unsafe global::Java.Lang.Long Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ContentProperties']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()Ljava/lang/Long;", "GetGetSizeHandler")]
			get {
				if (id_getSize == IntPtr.Zero)
					id_getSize = JNIEnv.GetMethodID (class_ref, "getSize", "()Ljava/lang/Long;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_getSize), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSize", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ContentProperties']/method[@name='setSize' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setSize", "(Ljava/lang/Long;)V", "GetSetSize_Ljava_lang_Long_Handler")]
			set {
				if (id_setSize_Ljava_lang_Long_ == IntPtr.Zero)
					id_setSize_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "setSize", "(Ljava/lang/Long;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSize_Ljava_lang_Long_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSize", "(Ljava/lang/Long;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersion);
			return cb_getVersion;
		}

		static IntPtr n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ContentProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Version);
		}
#pragma warning restore 0169

		static Delegate cb_setVersion_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetVersion_Ljava_lang_Long_Handler ()
		{
			if (cb_setVersion_Ljava_lang_Long_ == null)
				cb_setVersion_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVersion_Ljava_lang_Long_);
			return cb_setVersion_Ljava_lang_Long_;
		}

		static void n_SetVersion_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ContentProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Version = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getVersion;
		static IntPtr id_setVersion_Ljava_lang_Long_;
		public virtual unsafe global::Java.Lang.Long Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ContentProperties']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/Long;", "GetGetVersionHandler")]
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()Ljava/lang/Long;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_getVersion), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVersion", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ContentProperties']/method[@name='setVersion' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setVersion", "(Ljava/lang/Long;)V", "GetSetVersion_Ljava_lang_Long_Handler")]
			set {
				if (id_setVersion_Ljava_lang_Long_ == IntPtr.Zero)
					id_setVersion_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "setVersion", "(Ljava/lang/Long;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setVersion_Ljava_lang_Long_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVersion", "(Ljava/lang/Long;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVideo;
#pragma warning disable 0169
		static Delegate GetGetVideoHandler ()
		{
			if (cb_getVideo == null)
				cb_getVideo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVideo);
			return cb_getVideo;
		}

		static IntPtr n_GetVideo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ContentProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Video);
		}
#pragma warning restore 0169

		static Delegate cb_setVideo_Lcom_amazon_clouddrive_model_VideoProperties_;
#pragma warning disable 0169
		static Delegate GetSetVideo_Lcom_amazon_clouddrive_model_VideoProperties_Handler ()
		{
			if (cb_setVideo_Lcom_amazon_clouddrive_model_VideoProperties_ == null)
				cb_setVideo_Lcom_amazon_clouddrive_model_VideoProperties_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVideo_Lcom_amazon_clouddrive_model_VideoProperties_);
			return cb_setVideo_Lcom_amazon_clouddrive_model_VideoProperties_;
		}

		static void n_SetVideo_Lcom_amazon_clouddrive_model_VideoProperties_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ContentProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.VideoProperties p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Video = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getVideo;
		static IntPtr id_setVideo_Lcom_amazon_clouddrive_model_VideoProperties_;
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.VideoProperties Video {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ContentProperties']/method[@name='getVideo' and count(parameter)=0]"
			[Register ("getVideo", "()Lcom/amazon/clouddrive/model/VideoProperties;", "GetGetVideoHandler")]
			get {
				if (id_getVideo == IntPtr.Zero)
					id_getVideo = JNIEnv.GetMethodID (class_ref, "getVideo", "()Lcom/amazon/clouddrive/model/VideoProperties;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (JNIEnv.CallObjectMethod  (Handle, id_getVideo), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.VideoProperties> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideo", "()Lcom/amazon/clouddrive/model/VideoProperties;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ContentProperties']/method[@name='setVideo' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.VideoProperties']]"
			[Register ("setVideo", "(Lcom/amazon/clouddrive/model/VideoProperties;)V", "GetSetVideo_Lcom_amazon_clouddrive_model_VideoProperties_Handler")]
			set {
				if (id_setVideo_Lcom_amazon_clouddrive_model_VideoProperties_ == IntPtr.Zero)
					id_setVideo_Lcom_amazon_clouddrive_model_VideoProperties_ = JNIEnv.GetMethodID (class_ref, "setVideo", "(Lcom/amazon/clouddrive/model/VideoProperties;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setVideo_Lcom_amazon_clouddrive_model_VideoProperties_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVideo", "(Lcom/amazon/clouddrive/model/VideoProperties;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_compareTo_Lcom_amazon_clouddrive_model_ContentProperties_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lcom_amazon_clouddrive_model_ContentProperties_Handler ()
		{
			if (cb_compareTo_Lcom_amazon_clouddrive_model_ContentProperties_ == null)
				cb_compareTo_Lcom_amazon_clouddrive_model_ContentProperties_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lcom_amazon_clouddrive_model_ContentProperties_);
			return cb_compareTo_Lcom_amazon_clouddrive_model_ContentProperties_;
		}

		static int n_CompareTo_Lcom_amazon_clouddrive_model_ContentProperties_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ContentProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ContentProperties p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_amazon_clouddrive_model_ContentProperties_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ContentProperties']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.ContentProperties']]"
		[Register ("compareTo", "(Lcom/amazon/clouddrive/model/ContentProperties;)I", "GetCompareTo_Lcom_amazon_clouddrive_model_ContentProperties_Handler")]
		public virtual unsafe int CompareTo (global::Com.Amazon.Clouddrive.Model.ContentProperties p0)
		{
			if (id_compareTo_Lcom_amazon_clouddrive_model_ContentProperties_ == IntPtr.Zero)
				id_compareTo_Lcom_amazon_clouddrive_model_ContentProperties_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lcom/amazon/clouddrive/model/ContentProperties;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Lcom_amazon_clouddrive_model_ContentProperties_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lcom/amazon/clouddrive/model/ContentProperties;)I"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
