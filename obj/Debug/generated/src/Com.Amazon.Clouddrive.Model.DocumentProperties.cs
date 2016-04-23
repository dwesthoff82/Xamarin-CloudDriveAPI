using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='DocumentProperties']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/DocumentProperties", DoNotGenerateAcw=true)]
	public partial class DocumentProperties : global::Java.Lang.Object, global::Java.Lang.IComparable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/DocumentProperties", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DocumentProperties); }
		}

		protected DocumentProperties (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='DocumentProperties']/constructor[@name='DocumentProperties' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DocumentProperties ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DocumentProperties)) {
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

		static Delegate cb_getAuthors;
#pragma warning disable 0169
		static Delegate GetGetAuthorsHandler ()
		{
			if (cb_getAuthors == null)
				cb_getAuthors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthors);
			return cb_getAuthors;
		}

		static IntPtr n_GetAuthors (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.DocumentProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DocumentProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Authors);
		}
#pragma warning restore 0169

		static Delegate cb_setAuthors_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetAuthors_Ljava_util_List_Handler ()
		{
			if (cb_setAuthors_Ljava_util_List_ == null)
				cb_setAuthors_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAuthors_Ljava_util_List_);
			return cb_setAuthors_Ljava_util_List_;
		}

		static void n_SetAuthors_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.DocumentProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DocumentProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Authors = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAuthors;
		static IntPtr id_setAuthors_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<string> Authors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='DocumentProperties']/method[@name='getAuthors' and count(parameter)=0]"
			[Register ("getAuthors", "()Ljava/util/List;", "GetGetAuthorsHandler")]
			get {
				if (id_getAuthors == IntPtr.Zero)
					id_getAuthors = JNIEnv.GetMethodID (class_ref, "getAuthors", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getAuthors), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthors", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='DocumentProperties']/method[@name='setAuthors' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setAuthors", "(Ljava/util/List;)V", "GetSetAuthors_Ljava_util_List_Handler")]
			set {
				if (id_setAuthors_Ljava_util_List_ == IntPtr.Zero)
					id_setAuthors_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setAuthors", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAuthors_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAuthors", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDocumentVersion;
#pragma warning disable 0169
		static Delegate GetGetDocumentVersionHandler ()
		{
			if (cb_getDocumentVersion == null)
				cb_getDocumentVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDocumentVersion);
			return cb_getDocumentVersion;
		}

		static IntPtr n_GetDocumentVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.DocumentProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DocumentProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DocumentVersion);
		}
#pragma warning restore 0169

		static Delegate cb_setDocumentVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDocumentVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setDocumentVersion_Ljava_lang_String_ == null)
				cb_setDocumentVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDocumentVersion_Ljava_lang_String_);
			return cb_setDocumentVersion_Ljava_lang_String_;
		}

		static void n_SetDocumentVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.DocumentProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DocumentProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DocumentVersion = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDocumentVersion;
		static IntPtr id_setDocumentVersion_Ljava_lang_String_;
		public virtual unsafe string DocumentVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='DocumentProperties']/method[@name='getDocumentVersion' and count(parameter)=0]"
			[Register ("getDocumentVersion", "()Ljava/lang/String;", "GetGetDocumentVersionHandler")]
			get {
				if (id_getDocumentVersion == IntPtr.Zero)
					id_getDocumentVersion = JNIEnv.GetMethodID (class_ref, "getDocumentVersion", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDocumentVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDocumentVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='DocumentProperties']/method[@name='setDocumentVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDocumentVersion", "(Ljava/lang/String;)V", "GetSetDocumentVersion_Ljava_lang_String_Handler")]
			set {
				if (id_setDocumentVersion_Ljava_lang_String_ == IntPtr.Zero)
					id_setDocumentVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDocumentVersion", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDocumentVersion_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDocumentVersion", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.DocumentProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DocumentProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTitle_Ljava_lang_String_ == null)
				cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_String_);
			return cb_setTitle_Ljava_lang_String_;
		}

		static void n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.DocumentProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DocumentProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Title = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		static IntPtr id_setTitle_Ljava_lang_String_;
		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='DocumentProperties']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='DocumentProperties']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTitle_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitle", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_compareTo_Lcom_amazon_clouddrive_model_DocumentProperties_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lcom_amazon_clouddrive_model_DocumentProperties_Handler ()
		{
			if (cb_compareTo_Lcom_amazon_clouddrive_model_DocumentProperties_ == null)
				cb_compareTo_Lcom_amazon_clouddrive_model_DocumentProperties_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lcom_amazon_clouddrive_model_DocumentProperties_);
			return cb_compareTo_Lcom_amazon_clouddrive_model_DocumentProperties_;
		}

		static int n_CompareTo_Lcom_amazon_clouddrive_model_DocumentProperties_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.DocumentProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DocumentProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.DocumentProperties p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DocumentProperties> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_amazon_clouddrive_model_DocumentProperties_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='DocumentProperties']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.DocumentProperties']]"
		[Register ("compareTo", "(Lcom/amazon/clouddrive/model/DocumentProperties;)I", "GetCompareTo_Lcom_amazon_clouddrive_model_DocumentProperties_Handler")]
		public virtual unsafe int CompareTo (global::Com.Amazon.Clouddrive.Model.DocumentProperties p0)
		{
			if (id_compareTo_Lcom_amazon_clouddrive_model_DocumentProperties_ == IntPtr.Zero)
				id_compareTo_Lcom_amazon_clouddrive_model_DocumentProperties_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lcom/amazon/clouddrive/model/DocumentProperties;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Lcom_amazon_clouddrive_model_DocumentProperties_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lcom/amazon/clouddrive/model/DocumentProperties;)I"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
