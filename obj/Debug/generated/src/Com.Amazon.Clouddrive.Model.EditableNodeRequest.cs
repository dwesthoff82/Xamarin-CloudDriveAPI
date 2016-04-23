using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='EditableNodeRequest']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/EditableNodeRequest", DoNotGenerateAcw=true)]
	public partial class EditableNodeRequest : global::Java.Lang.Object, global::Com.Amazon.Clouddrive.Model.ICloudDriveRequest, global::Com.Amazon.Clouddrive.Model.IEditableNode {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/EditableNodeRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EditableNodeRequest); }
		}

		protected EditableNodeRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='EditableNodeRequest']/constructor[@name='EditableNodeRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EditableNodeRequest ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (EditableNodeRequest)) {
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

		static Delegate cb_getContentProperties;
#pragma warning disable 0169
		static Delegate GetGetContentPropertiesHandler ()
		{
			if (cb_getContentProperties == null)
				cb_getContentProperties = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentProperties);
			return cb_getContentProperties;
		}

		static IntPtr n_GetContentProperties (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.EditableNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.EditableNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentProperties);
		}
#pragma warning restore 0169

		static Delegate cb_setContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_;
#pragma warning disable 0169
		static Delegate GetSetContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_Handler ()
		{
			if (cb_setContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_ == null)
				cb_setContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_);
			return cb_setContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_;
		}

		static void n_SetContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.EditableNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.EditableNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ContentProperties p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ContentProperties = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContentProperties;
		static IntPtr id_setContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_;
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.ContentProperties ContentProperties {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='EditableNodeRequest']/method[@name='getContentProperties' and count(parameter)=0]"
			[Register ("getContentProperties", "()Lcom/amazon/clouddrive/model/ContentProperties;", "GetGetContentPropertiesHandler")]
			get {
				if (id_getContentProperties == IntPtr.Zero)
					id_getContentProperties = JNIEnv.GetMethodID (class_ref, "getContentProperties", "()Lcom/amazon/clouddrive/model/ContentProperties;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (JNIEnv.CallObjectMethod  (Handle, id_getContentProperties), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentProperties", "()Lcom/amazon/clouddrive/model/ContentProperties;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='EditableNodeRequest']/method[@name='setContentProperties' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.ContentProperties']]"
			[Register ("setContentProperties", "(Lcom/amazon/clouddrive/model/ContentProperties;)V", "GetSetContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_Handler")]
			set {
				if (id_setContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_ == IntPtr.Zero)
					id_setContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_ = JNIEnv.GetMethodID (class_ref, "setContentProperties", "(Lcom/amazon/clouddrive/model/ContentProperties;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContentProperties", "(Lcom/amazon/clouddrive/model/ContentProperties;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.EditableNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.EditableNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Description);
		}
#pragma warning restore 0169

		static Delegate cb_setDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDescription_Ljava_lang_String_Handler ()
		{
			if (cb_setDescription_Ljava_lang_String_ == null)
				cb_setDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDescription_Ljava_lang_String_);
			return cb_setDescription_Ljava_lang_String_;
		}

		static void n_SetDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.EditableNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.EditableNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Description = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDescription;
		static IntPtr id_setDescription_Ljava_lang_String_;
		public virtual unsafe string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='EditableNodeRequest']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDescription", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='EditableNodeRequest']/method[@name='setDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDescription", "(Ljava/lang/String;)V", "GetSetDescription_Ljava_lang_String_Handler")]
			set {
				if (id_setDescription_Ljava_lang_String_ == IntPtr.Zero)
					id_setDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDescription", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDescription_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDescription", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.EditableNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.EditableNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static Delegate cb_setId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetId_Ljava_lang_String_Handler ()
		{
			if (cb_setId_Ljava_lang_String_ == null)
				cb_setId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetId_Ljava_lang_String_);
			return cb_setId_Ljava_lang_String_;
		}

		static void n_SetId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.EditableNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.EditableNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		static IntPtr id_setId_Ljava_lang_String_;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='EditableNodeRequest']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='EditableNodeRequest']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setId", "(Ljava/lang/String;)V", "GetSetId_Ljava_lang_String_Handler")]
			set {
				if (id_setId_Ljava_lang_String_ == IntPtr.Zero)
					id_setId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getKind;
#pragma warning disable 0169
		static Delegate GetGetKindHandler ()
		{
			if (cb_getKind == null)
				cb_getKind = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKind);
			return cb_getKind;
		}

		static IntPtr n_GetKind (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.EditableNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.EditableNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Kind);
		}
#pragma warning restore 0169

		static Delegate cb_setKind_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetKind_Ljava_lang_String_Handler ()
		{
			if (cb_setKind_Ljava_lang_String_ == null)
				cb_setKind_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetKind_Ljava_lang_String_);
			return cb_setKind_Ljava_lang_String_;
		}

		static void n_SetKind_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.EditableNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.EditableNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Kind = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getKind;
		static IntPtr id_setKind_Ljava_lang_String_;
		public virtual unsafe string Kind {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='EditableNodeRequest']/method[@name='getKind' and count(parameter)=0]"
			[Register ("getKind", "()Ljava/lang/String;", "GetGetKindHandler")]
			get {
				if (id_getKind == IntPtr.Zero)
					id_getKind = JNIEnv.GetMethodID (class_ref, "getKind", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getKind), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKind", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='EditableNodeRequest']/method[@name='setKind' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setKind", "(Ljava/lang/String;)V", "GetSetKind_Ljava_lang_String_Handler")]
			set {
				if (id_setKind_Ljava_lang_String_ == IntPtr.Zero)
					id_setKind_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setKind", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setKind_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKind", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getLabels;
#pragma warning disable 0169
		static Delegate GetGetLabelsHandler ()
		{
			if (cb_getLabels == null)
				cb_getLabels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLabels);
			return cb_getLabels;
		}

		static IntPtr n_GetLabels (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.EditableNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.EditableNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Labels);
		}
#pragma warning restore 0169

		static Delegate cb_setLabels_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetLabels_Ljava_util_List_Handler ()
		{
			if (cb_setLabels_Ljava_util_List_ == null)
				cb_setLabels_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLabels_Ljava_util_List_);
			return cb_setLabels_Ljava_util_List_;
		}

		static void n_SetLabels_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.EditableNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.EditableNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Labels = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLabels;
		static IntPtr id_setLabels_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<string> Labels {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='EditableNodeRequest']/method[@name='getLabels' and count(parameter)=0]"
			[Register ("getLabels", "()Ljava/util/List;", "GetGetLabelsHandler")]
			get {
				if (id_getLabels == IntPtr.Zero)
					id_getLabels = JNIEnv.GetMethodID (class_ref, "getLabels", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getLabels), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLabels", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='EditableNodeRequest']/method[@name='setLabels' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setLabels", "(Ljava/util/List;)V", "GetSetLabels_Ljava_util_List_Handler")]
			set {
				if (id_setLabels_Ljava_util_List_ == IntPtr.Zero)
					id_setLabels_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setLabels", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setLabels_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLabels", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.EditableNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.EditableNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.EditableNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.EditableNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Name = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		static IntPtr id_setName_Ljava_lang_String_;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='EditableNodeRequest']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='EditableNodeRequest']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")]
			set {
				if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
					id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getParents;
#pragma warning disable 0169
		static Delegate GetGetParentsHandler ()
		{
			if (cb_getParents == null)
				cb_getParents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParents);
			return cb_getParents;
		}

		static IntPtr n_GetParents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.EditableNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.EditableNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Parents);
		}
#pragma warning restore 0169

		static Delegate cb_setParents_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetParents_Ljava_util_List_Handler ()
		{
			if (cb_setParents_Ljava_util_List_ == null)
				cb_setParents_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetParents_Ljava_util_List_);
			return cb_setParents_Ljava_util_List_;
		}

		static void n_SetParents_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.EditableNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.EditableNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Parents = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getParents;
		static IntPtr id_setParents_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<string> Parents {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='EditableNodeRequest']/method[@name='getParents' and count(parameter)=0]"
			[Register ("getParents", "()Ljava/util/List;", "GetGetParentsHandler")]
			get {
				if (id_getParents == IntPtr.Zero)
					id_getParents = JNIEnv.GetMethodID (class_ref, "getParents", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getParents), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParents", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='EditableNodeRequest']/method[@name='setParents' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setParents", "(Ljava/util/List;)V", "GetSetParents_Ljava_util_List_Handler")]
			set {
				if (id_setParents_Ljava_util_List_ == IntPtr.Zero)
					id_setParents_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setParents", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setParents_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setParents", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getProperties;
#pragma warning disable 0169
		static Delegate GetGetPropertiesHandler ()
		{
			if (cb_getProperties == null)
				cb_getProperties = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProperties);
			return cb_getProperties;
		}

		static IntPtr n_GetProperties (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.EditableNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.EditableNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IDictionary<string, string>>.ToLocalJniHandle (__this.Properties);
		}
#pragma warning restore 0169

		static Delegate cb_setProperties_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetProperties_Ljava_util_Map_Handler ()
		{
			if (cb_setProperties_Ljava_util_Map_ == null)
				cb_setProperties_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProperties_Ljava_util_Map_);
			return cb_setProperties_Ljava_util_Map_;
		}

		static void n_SetProperties_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.EditableNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.EditableNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IDictionary<string, string>>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Properties = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getProperties;
		static IntPtr id_setProperties_Ljava_util_Map_;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IDictionary<string, string>> Properties {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='EditableNodeRequest']/method[@name='getProperties' and count(parameter)=0]"
			[Register ("getProperties", "()Ljava/util/Map;", "GetGetPropertiesHandler")]
			get {
				if (id_getProperties == IntPtr.Zero)
					id_getProperties = JNIEnv.GetMethodID (class_ref, "getProperties", "()Ljava/util/Map;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IDictionary<string, string>>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getProperties), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IDictionary<string, string>>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProperties", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='EditableNodeRequest']/method[@name='setProperties' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.util.Map&lt;java.lang.String, java.lang.String&gt;&gt;']]"
			[Register ("setProperties", "(Ljava/util/Map;)V", "GetSetProperties_Ljava_util_Map_Handler")]
			set {
				if (id_setProperties_Ljava_util_Map_ == IntPtr.Zero)
					id_setProperties_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setProperties", "(Ljava/util/Map;)V");
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IDictionary<string, string>>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setProperties_Ljava_util_Map_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setProperties", "(Ljava/util/Map;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatus);
			return cb_getStatus;
		}

		static IntPtr n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.EditableNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.EditableNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Status);
		}
#pragma warning restore 0169

		static Delegate cb_setStatus_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStatus_Ljava_lang_String_Handler ()
		{
			if (cb_setStatus_Ljava_lang_String_ == null)
				cb_setStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStatus_Ljava_lang_String_);
			return cb_setStatus_Ljava_lang_String_;
		}

		static void n_SetStatus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.EditableNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.EditableNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Status = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		static IntPtr id_setStatus_Ljava_lang_String_;
		public virtual unsafe string Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='EditableNodeRequest']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Ljava/lang/String;", "GetGetStatusHandler")]
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatus", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='EditableNodeRequest']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStatus", "(Ljava/lang/String;)V", "GetSetStatus_Ljava_lang_String_Handler")]
			set {
				if (id_setStatus_Ljava_lang_String_ == IntPtr.Zero)
					id_setStatus_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStatus", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setStatus_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatus", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_Handler ()
		{
			if (cb_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_ == null)
				cb_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_);
			return cb_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_;
		}

		static int n_CompareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.EditableNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.EditableNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ICloudDriveRequest p0 = (global::Com.Amazon.Clouddrive.Model.ICloudDriveRequest)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ICloudDriveRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='EditableNodeRequest']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.CloudDriveRequest']]"
		[Register ("compareTo", "(Lcom/amazon/clouddrive/model/CloudDriveRequest;)I", "GetCompareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_Handler")]
		public virtual unsafe int CompareTo (global::Com.Amazon.Clouddrive.Model.ICloudDriveRequest p0)
		{
			if (id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_ == IntPtr.Zero)
				id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lcom/amazon/clouddrive/model/CloudDriveRequest;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lcom/amazon/clouddrive/model/CloudDriveRequest;)I"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
