using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='IEditableNode']"
	[Register ("com/amazon/clouddrive/model/IEditableNode", "", "Com.Amazon.Clouddrive.Model.IEditableNodeInvoker")]
	public partial interface IEditableNode : IJavaObject {

		global::Com.Amazon.Clouddrive.Model.ContentProperties ContentProperties {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='IEditableNode']/method[@name='getContentProperties' and count(parameter)=0]"
			[Register ("getContentProperties", "()Lcom/amazon/clouddrive/model/ContentProperties;", "GetGetContentPropertiesHandler:Com.Amazon.Clouddrive.Model.IEditableNodeInvoker, CloudDriveAPI")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='IEditableNode']/method[@name='setContentProperties' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.ContentProperties']]"
			[Register ("setContentProperties", "(Lcom/amazon/clouddrive/model/ContentProperties;)V", "GetSetContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_Handler:Com.Amazon.Clouddrive.Model.IEditableNodeInvoker, CloudDriveAPI")] set;
		}

		string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='IEditableNode']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler:Com.Amazon.Clouddrive.Model.IEditableNodeInvoker, CloudDriveAPI")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='IEditableNode']/method[@name='setDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDescription", "(Ljava/lang/String;)V", "GetSetDescription_Ljava_lang_String_Handler:Com.Amazon.Clouddrive.Model.IEditableNodeInvoker, CloudDriveAPI")] set;
		}

		string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='IEditableNode']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler:Com.Amazon.Clouddrive.Model.IEditableNodeInvoker, CloudDriveAPI")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='IEditableNode']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setId", "(Ljava/lang/String;)V", "GetSetId_Ljava_lang_String_Handler:Com.Amazon.Clouddrive.Model.IEditableNodeInvoker, CloudDriveAPI")] set;
		}

		string Kind {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='IEditableNode']/method[@name='getKind' and count(parameter)=0]"
			[Register ("getKind", "()Ljava/lang/String;", "GetGetKindHandler:Com.Amazon.Clouddrive.Model.IEditableNodeInvoker, CloudDriveAPI")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='IEditableNode']/method[@name='setKind' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setKind", "(Ljava/lang/String;)V", "GetSetKind_Ljava_lang_String_Handler:Com.Amazon.Clouddrive.Model.IEditableNodeInvoker, CloudDriveAPI")] set;
		}

		global::System.Collections.Generic.IList<string> Labels {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='IEditableNode']/method[@name='getLabels' and count(parameter)=0]"
			[Register ("getLabels", "()Ljava/util/List;", "GetGetLabelsHandler:Com.Amazon.Clouddrive.Model.IEditableNodeInvoker, CloudDriveAPI")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='IEditableNode']/method[@name='setLabels' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setLabels", "(Ljava/util/List;)V", "GetSetLabels_Ljava_util_List_Handler:Com.Amazon.Clouddrive.Model.IEditableNodeInvoker, CloudDriveAPI")] set;
		}

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='IEditableNode']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Com.Amazon.Clouddrive.Model.IEditableNodeInvoker, CloudDriveAPI")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='IEditableNode']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler:Com.Amazon.Clouddrive.Model.IEditableNodeInvoker, CloudDriveAPI")] set;
		}

		global::System.Collections.Generic.IList<string> Parents {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='IEditableNode']/method[@name='getParents' and count(parameter)=0]"
			[Register ("getParents", "()Ljava/util/List;", "GetGetParentsHandler:Com.Amazon.Clouddrive.Model.IEditableNodeInvoker, CloudDriveAPI")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='IEditableNode']/method[@name='setParents' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setParents", "(Ljava/util/List;)V", "GetSetParents_Ljava_util_List_Handler:Com.Amazon.Clouddrive.Model.IEditableNodeInvoker, CloudDriveAPI")] set;
		}

		global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IDictionary<string, string>> Properties {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='IEditableNode']/method[@name='getProperties' and count(parameter)=0]"
			[Register ("getProperties", "()Ljava/util/Map;", "GetGetPropertiesHandler:Com.Amazon.Clouddrive.Model.IEditableNodeInvoker, CloudDriveAPI")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='IEditableNode']/method[@name='setProperties' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.util.Map&lt;java.lang.String, java.lang.String&gt;&gt;']]"
			[Register ("setProperties", "(Ljava/util/Map;)V", "GetSetProperties_Ljava_util_Map_Handler:Com.Amazon.Clouddrive.Model.IEditableNodeInvoker, CloudDriveAPI")] set;
		}

		string Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='IEditableNode']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Ljava/lang/String;", "GetGetStatusHandler:Com.Amazon.Clouddrive.Model.IEditableNodeInvoker, CloudDriveAPI")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='IEditableNode']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStatus", "(Ljava/lang/String;)V", "GetSetStatus_Ljava_lang_String_Handler:Com.Amazon.Clouddrive.Model.IEditableNodeInvoker, CloudDriveAPI")] set;
		}

	}

	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/IEditableNode", DoNotGenerateAcw=true)]
	internal class IEditableNodeInvoker : global::Java.Lang.Object, IEditableNode {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/clouddrive/model/IEditableNode");
		IntPtr class_ref;

		public static IEditableNode GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEditableNode> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.clouddrive.model.IEditableNode"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEditableNodeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IEditableNodeInvoker); }
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
			global::Com.Amazon.Clouddrive.Model.IEditableNode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.IEditableNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Clouddrive.Model.IEditableNode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.IEditableNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ContentProperties p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ContentProperties = p0;
		}
#pragma warning restore 0169

		IntPtr id_getContentProperties;
		IntPtr id_setContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_;
		public unsafe global::Com.Amazon.Clouddrive.Model.ContentProperties ContentProperties {
			get {
				if (id_getContentProperties == IntPtr.Zero)
					id_getContentProperties = JNIEnv.GetMethodID (class_ref, "getContentProperties", "()Lcom/amazon/clouddrive/model/ContentProperties;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (JNIEnv.CallObjectMethod (Handle, id_getContentProperties), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_ == IntPtr.Zero)
					id_setContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_ = JNIEnv.GetMethodID (class_ref, "setContentProperties", "(Lcom/amazon/clouddrive/model/ContentProperties;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (Handle, id_setContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_, __args);
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
			global::Com.Amazon.Clouddrive.Model.IEditableNode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.IEditableNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Clouddrive.Model.IEditableNode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.IEditableNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Description = p0;
		}
#pragma warning restore 0169

		IntPtr id_getDescription;
		IntPtr id_setDescription_Ljava_lang_String_;
		public unsafe string Description {
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setDescription_Ljava_lang_String_ == IntPtr.Zero)
					id_setDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDescription", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (Handle, id_setDescription_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Amazon.Clouddrive.Model.IEditableNode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.IEditableNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Clouddrive.Model.IEditableNode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.IEditableNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		IntPtr id_getId;
		IntPtr id_setId_Ljava_lang_String_;
		public unsafe string Id {
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setId_Ljava_lang_String_ == IntPtr.Zero)
					id_setId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (Handle, id_setId_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Amazon.Clouddrive.Model.IEditableNode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.IEditableNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Clouddrive.Model.IEditableNode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.IEditableNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Kind = p0;
		}
#pragma warning restore 0169

		IntPtr id_getKind;
		IntPtr id_setKind_Ljava_lang_String_;
		public unsafe string Kind {
			get {
				if (id_getKind == IntPtr.Zero)
					id_getKind = JNIEnv.GetMethodID (class_ref, "getKind", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getKind), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setKind_Ljava_lang_String_ == IntPtr.Zero)
					id_setKind_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setKind", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (Handle, id_setKind_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Amazon.Clouddrive.Model.IEditableNode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.IEditableNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Clouddrive.Model.IEditableNode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.IEditableNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Labels = p0;
		}
#pragma warning restore 0169

		IntPtr id_getLabels;
		IntPtr id_setLabels_Ljava_util_List_;
		public unsafe global::System.Collections.Generic.IList<string> Labels {
			get {
				if (id_getLabels == IntPtr.Zero)
					id_getLabels = JNIEnv.GetMethodID (class_ref, "getLabels", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getLabels), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setLabels_Ljava_util_List_ == IntPtr.Zero)
					id_setLabels_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setLabels", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (Handle, id_setLabels_Ljava_util_List_, __args);
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Amazon.Clouddrive.Model.IEditableNode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.IEditableNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Clouddrive.Model.IEditableNode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.IEditableNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Name = p0;
		}
#pragma warning restore 0169

		IntPtr id_getName;
		IntPtr id_setName_Ljava_lang_String_;
		public unsafe string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
					id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (Handle, id_setName_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Amazon.Clouddrive.Model.IEditableNode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.IEditableNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Clouddrive.Model.IEditableNode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.IEditableNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Parents = p0;
		}
#pragma warning restore 0169

		IntPtr id_getParents;
		IntPtr id_setParents_Ljava_util_List_;
		public unsafe global::System.Collections.Generic.IList<string> Parents {
			get {
				if (id_getParents == IntPtr.Zero)
					id_getParents = JNIEnv.GetMethodID (class_ref, "getParents", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getParents), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setParents_Ljava_util_List_ == IntPtr.Zero)
					id_setParents_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setParents", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (Handle, id_setParents_Ljava_util_List_, __args);
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Amazon.Clouddrive.Model.IEditableNode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.IEditableNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Clouddrive.Model.IEditableNode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.IEditableNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IDictionary<string, string>>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Properties = p0;
		}
#pragma warning restore 0169

		IntPtr id_getProperties;
		IntPtr id_setProperties_Ljava_util_Map_;
		public unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IDictionary<string, string>> Properties {
			get {
				if (id_getProperties == IntPtr.Zero)
					id_getProperties = JNIEnv.GetMethodID (class_ref, "getProperties", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IDictionary<string, string>>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getProperties), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setProperties_Ljava_util_Map_ == IntPtr.Zero)
					id_setProperties_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setProperties", "(Ljava/util/Map;)V");
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IDictionary<string, string>>.ToLocalJniHandle (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (Handle, id_setProperties_Ljava_util_Map_, __args);
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Amazon.Clouddrive.Model.IEditableNode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.IEditableNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Clouddrive.Model.IEditableNode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.IEditableNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Status = p0;
		}
#pragma warning restore 0169

		IntPtr id_getStatus;
		IntPtr id_setStatus_Ljava_lang_String_;
		public unsafe string Status {
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setStatus_Ljava_lang_String_ == IntPtr.Zero)
					id_setStatus_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStatus", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (Handle, id_setStatus_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}

}
