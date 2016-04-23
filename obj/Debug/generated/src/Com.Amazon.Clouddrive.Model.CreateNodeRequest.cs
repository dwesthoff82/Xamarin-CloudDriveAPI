using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='CreateNodeRequest']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/CreateNodeRequest", DoNotGenerateAcw=true)]
	public partial class CreateNodeRequest : global::Com.Amazon.Clouddrive.Model.PostNodeRequest {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/CreateNodeRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CreateNodeRequest); }
		}

		protected CreateNodeRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='CreateNodeRequest']/constructor[@name='CreateNodeRequest' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe CreateNodeRequest (string p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (CreateNodeRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_withContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_;
#pragma warning disable 0169
		static Delegate GetWithContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_Handler ()
		{
			if (cb_withContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_ == null)
				cb_withContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_);
			return cb_withContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_;
		}

		static IntPtr n_WithContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.CreateNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.CreateNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ContentProperties p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithContentProperties (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='CreateNodeRequest']/method[@name='withContentProperties' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.ContentProperties']]"
		[Register ("withContentProperties", "(Lcom/amazon/clouddrive/model/ContentProperties;)Lcom/amazon/clouddrive/model/CreateNodeRequest;", "GetWithContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.CreateNodeRequest WithContentProperties (global::Com.Amazon.Clouddrive.Model.ContentProperties p0)
		{
			if (id_withContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_ == IntPtr.Zero)
				id_withContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_ = JNIEnv.GetMethodID (class_ref, "withContentProperties", "(Lcom/amazon/clouddrive/model/ContentProperties;)Lcom/amazon/clouddrive/model/CreateNodeRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Model.CreateNodeRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.CreateNodeRequest> (JNIEnv.CallObjectMethod  (Handle, id_withContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.CreateNodeRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withContentProperties", "(Lcom/amazon/clouddrive/model/ContentProperties;)Lcom/amazon/clouddrive/model/CreateNodeRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithDescription_Ljava_lang_String_Handler ()
		{
			if (cb_withDescription_Ljava_lang_String_ == null)
				cb_withDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithDescription_Ljava_lang_String_);
			return cb_withDescription_Ljava_lang_String_;
		}

		static IntPtr n_WithDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.CreateNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.CreateNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithDescription (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withDescription_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='CreateNodeRequest']/method[@name='withDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withDescription", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/CreateNodeRequest;", "GetWithDescription_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.CreateNodeRequest WithDescription (string p0)
		{
			if (id_withDescription_Ljava_lang_String_ == IntPtr.Zero)
				id_withDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withDescription", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/CreateNodeRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Amazon.Clouddrive.Model.CreateNodeRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.CreateNodeRequest> (JNIEnv.CallObjectMethod  (Handle, id_withDescription_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.CreateNodeRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withDescription", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/CreateNodeRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withKind_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithKind_Ljava_lang_String_Handler ()
		{
			if (cb_withKind_Ljava_lang_String_ == null)
				cb_withKind_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithKind_Ljava_lang_String_);
			return cb_withKind_Ljava_lang_String_;
		}

		static IntPtr n_WithKind_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.CreateNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.CreateNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithKind (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withKind_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='CreateNodeRequest']/method[@name='withKind' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withKind", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/CreateNodeRequest;", "GetWithKind_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.CreateNodeRequest WithKind (string p0)
		{
			if (id_withKind_Ljava_lang_String_ == IntPtr.Zero)
				id_withKind_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withKind", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/CreateNodeRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Amazon.Clouddrive.Model.CreateNodeRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.CreateNodeRequest> (JNIEnv.CallObjectMethod  (Handle, id_withKind_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.CreateNodeRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withKind", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/CreateNodeRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withLabels_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetWithLabels_Ljava_util_List_Handler ()
		{
			if (cb_withLabels_Ljava_util_List_ == null)
				cb_withLabels_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithLabels_Ljava_util_List_);
			return cb_withLabels_Ljava_util_List_;
		}

		static IntPtr n_WithLabels_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.CreateNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.CreateNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithLabels (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withLabels_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='CreateNodeRequest']/method[@name='withLabels' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("withLabels", "(Ljava/util/List;)Lcom/amazon/clouddrive/model/CreateNodeRequest;", "GetWithLabels_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.CreateNodeRequest WithLabels (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_withLabels_Ljava_util_List_ == IntPtr.Zero)
				id_withLabels_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "withLabels", "(Ljava/util/List;)Lcom/amazon/clouddrive/model/CreateNodeRequest;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Amazon.Clouddrive.Model.CreateNodeRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.CreateNodeRequest> (JNIEnv.CallObjectMethod  (Handle, id_withLabels_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.CreateNodeRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withLabels", "(Ljava/util/List;)Lcom/amazon/clouddrive/model/CreateNodeRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withLocalId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithLocalId_Ljava_lang_String_Handler ()
		{
			if (cb_withLocalId_Ljava_lang_String_ == null)
				cb_withLocalId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithLocalId_Ljava_lang_String_);
			return cb_withLocalId_Ljava_lang_String_;
		}

		static IntPtr n_WithLocalId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.CreateNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.CreateNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithLocalId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withLocalId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='CreateNodeRequest']/method[@name='withLocalId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withLocalId", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/CreateNodeRequest;", "GetWithLocalId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.CreateNodeRequest WithLocalId (string p0)
		{
			if (id_withLocalId_Ljava_lang_String_ == IntPtr.Zero)
				id_withLocalId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withLocalId", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/CreateNodeRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Amazon.Clouddrive.Model.CreateNodeRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.CreateNodeRequest> (JNIEnv.CallObjectMethod  (Handle, id_withLocalId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.CreateNodeRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withLocalId", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/CreateNodeRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withParents_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetWithParents_Ljava_util_List_Handler ()
		{
			if (cb_withParents_Ljava_util_List_ == null)
				cb_withParents_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithParents_Ljava_util_List_);
			return cb_withParents_Ljava_util_List_;
		}

		static IntPtr n_WithParents_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.CreateNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.CreateNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithParents (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withParents_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='CreateNodeRequest']/method[@name='withParents' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("withParents", "(Ljava/util/List;)Lcom/amazon/clouddrive/model/CreateNodeRequest;", "GetWithParents_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.CreateNodeRequest WithParents (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_withParents_Ljava_util_List_ == IntPtr.Zero)
				id_withParents_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "withParents", "(Ljava/util/List;)Lcom/amazon/clouddrive/model/CreateNodeRequest;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Amazon.Clouddrive.Model.CreateNodeRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.CreateNodeRequest> (JNIEnv.CallObjectMethod  (Handle, id_withParents_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.CreateNodeRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withParents", "(Ljava/util/List;)Lcom/amazon/clouddrive/model/CreateNodeRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withProperties_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetWithProperties_Ljava_util_Map_Handler ()
		{
			if (cb_withProperties_Ljava_util_Map_ == null)
				cb_withProperties_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithProperties_Ljava_util_Map_);
			return cb_withProperties_Ljava_util_Map_;
		}

		static IntPtr n_WithProperties_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.CreateNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.CreateNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IDictionary<string, string>>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithProperties (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withProperties_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='CreateNodeRequest']/method[@name='withProperties' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.util.Map&lt;java.lang.String, java.lang.String&gt;&gt;']]"
		[Register ("withProperties", "(Ljava/util/Map;)Lcom/amazon/clouddrive/model/CreateNodeRequest;", "GetWithProperties_Ljava_util_Map_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.CreateNodeRequest WithProperties (global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IDictionary<string, string>> p0)
		{
			if (id_withProperties_Ljava_util_Map_ == IntPtr.Zero)
				id_withProperties_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "withProperties", "(Ljava/util/Map;)Lcom/amazon/clouddrive/model/CreateNodeRequest;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IDictionary<string, string>>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Amazon.Clouddrive.Model.CreateNodeRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.CreateNodeRequest> (JNIEnv.CallObjectMethod  (Handle, id_withProperties_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.CreateNodeRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withProperties", "(Ljava/util/Map;)Lcom/amazon/clouddrive/model/CreateNodeRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
