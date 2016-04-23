using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.internal']/class[@name='OperationFactory']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/internal/OperationFactory", DoNotGenerateAcw=true)]
	public partial class OperationFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/internal/OperationFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OperationFactory); }
		}

		protected OperationFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_clouddrive_configuration_AccountConfiguration_Lcom_amazon_clouddrive_configuration_ClientConfiguration_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.internal']/class[@name='OperationFactory']/constructor[@name='OperationFactory' and count(parameter)=2 and parameter[1][@type='com.amazon.clouddrive.configuration.AccountConfiguration'] and parameter[2][@type='com.amazon.clouddrive.configuration.ClientConfiguration']]"
		[Register (".ctor", "(Lcom/amazon/clouddrive/configuration/AccountConfiguration;Lcom/amazon/clouddrive/configuration/ClientConfiguration;)V", "")]
		public unsafe OperationFactory (global::Com.Amazon.Clouddrive.Configuration.AccountConfiguration p0, global::Com.Amazon.Clouddrive.Configuration.ClientConfiguration p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (OperationFactory)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/clouddrive/configuration/AccountConfiguration;Lcom/amazon/clouddrive/configuration/ClientConfiguration;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/clouddrive/configuration/AccountConfiguration;Lcom/amazon/clouddrive/configuration/ClientConfiguration;)V", __args);
					return;
				}

				if (id_ctor_Lcom_amazon_clouddrive_configuration_AccountConfiguration_Lcom_amazon_clouddrive_configuration_ClientConfiguration_ == IntPtr.Zero)
					id_ctor_Lcom_amazon_clouddrive_configuration_AccountConfiguration_Lcom_amazon_clouddrive_configuration_ClientConfiguration_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/clouddrive/configuration/AccountConfiguration;Lcom/amazon/clouddrive/configuration/ClientConfiguration;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_clouddrive_configuration_AccountConfiguration_Lcom_amazon_clouddrive_configuration_ClientConfiguration_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_clouddrive_configuration_AccountConfiguration_Lcom_amazon_clouddrive_configuration_ClientConfiguration_, __args);
			} finally {
			}
		}

		static Delegate cb_clearEndpoints;
#pragma warning disable 0169
		static Delegate GetClearEndpointsHandler ()
		{
			if (cb_clearEndpoints == null)
				cb_clearEndpoints = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearEndpoints);
			return cb_clearEndpoints;
		}

		static void n_ClearEndpoints (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Internal.OperationFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.OperationFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearEndpoints ();
		}
#pragma warning restore 0169

		static IntPtr id_clearEndpoints;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.internal']/class[@name='OperationFactory']/method[@name='clearEndpoints' and count(parameter)=0]"
		[Register ("clearEndpoints", "()V", "GetClearEndpointsHandler")]
		public virtual unsafe void ClearEndpoints ()
		{
			if (id_clearEndpoints == IntPtr.Zero)
				id_clearEndpoints = JNIEnv.GetMethodID (class_ref, "clearEndpoints", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clearEndpoints);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearEndpoints", "()V"));
			} finally {
			}
		}

		static Delegate cb_newAddChildToParentOperation_Lcom_amazon_clouddrive_model_AddChildToParentRequest_;
#pragma warning disable 0169
		static Delegate GetNewAddChildToParentOperation_Lcom_amazon_clouddrive_model_AddChildToParentRequest_Handler ()
		{
			if (cb_newAddChildToParentOperation_Lcom_amazon_clouddrive_model_AddChildToParentRequest_ == null)
				cb_newAddChildToParentOperation_Lcom_amazon_clouddrive_model_AddChildToParentRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewAddChildToParentOperation_Lcom_amazon_clouddrive_model_AddChildToParentRequest_);
			return cb_newAddChildToParentOperation_Lcom_amazon_clouddrive_model_AddChildToParentRequest_;
		}

		static IntPtr n_NewAddChildToParentOperation_Lcom_amazon_clouddrive_model_AddChildToParentRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Internal.OperationFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.OperationFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewAddChildToParentOperation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newAddChildToParentOperation_Lcom_amazon_clouddrive_model_AddChildToParentRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.internal']/class[@name='OperationFactory']/method[@name='newAddChildToParentOperation' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.AddChildToParentRequest']]"
		[Register ("newAddChildToParentOperation", "(Lcom/amazon/clouddrive/model/AddChildToParentRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;", "GetNewAddChildToParentOperation_Lcom_amazon_clouddrive_model_AddChildToParentRequest_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation NewAddChildToParentOperation (global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest p0)
		{
			if (id_newAddChildToParentOperation_Lcom_amazon_clouddrive_model_AddChildToParentRequest_ == IntPtr.Zero)
				id_newAddChildToParentOperation_Lcom_amazon_clouddrive_model_AddChildToParentRequest_ = JNIEnv.GetMethodID (class_ref, "newAddChildToParentOperation", "(Lcom/amazon/clouddrive/model/AddChildToParentRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation> (JNIEnv.CallObjectMethod  (Handle, id_newAddChildToParentOperation_Lcom_amazon_clouddrive_model_AddChildToParentRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newAddChildToParentOperation", "(Lcom/amazon/clouddrive/model/AddChildToParentRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_newAddPropertyOperation_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_;
#pragma warning disable 0169
		static Delegate GetNewAddPropertyOperation_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_Handler ()
		{
			if (cb_newAddPropertyOperation_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_ == null)
				cb_newAddPropertyOperation_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewAddPropertyOperation_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_);
			return cb_newAddPropertyOperation_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_;
		}

		static IntPtr n_NewAddPropertyOperation_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Internal.OperationFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.OperationFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.AddNodePropertyRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.AddNodePropertyRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewAddPropertyOperation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newAddPropertyOperation_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.internal']/class[@name='OperationFactory']/method[@name='newAddPropertyOperation' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.AddNodePropertyRequest']]"
		[Register ("newAddPropertyOperation", "(Lcom/amazon/clouddrive/model/AddNodePropertyRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;", "GetNewAddPropertyOperation_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation NewAddPropertyOperation (global::Com.Amazon.Clouddrive.Model.AddNodePropertyRequest p0)
		{
			if (id_newAddPropertyOperation_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_ == IntPtr.Zero)
				id_newAddPropertyOperation_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_ = JNIEnv.GetMethodID (class_ref, "newAddPropertyOperation", "(Lcom/amazon/clouddrive/model/AddNodePropertyRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation> (JNIEnv.CallObjectMethod  (Handle, id_newAddPropertyOperation_Lcom_amazon_clouddrive_model_AddNodePropertyRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newAddPropertyOperation", "(Lcom/amazon/clouddrive/model/AddNodePropertyRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_newDeletePropertyOperation_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_;
#pragma warning disable 0169
		static Delegate GetNewDeletePropertyOperation_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_Handler ()
		{
			if (cb_newDeletePropertyOperation_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_ == null)
				cb_newDeletePropertyOperation_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewDeletePropertyOperation_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_);
			return cb_newDeletePropertyOperation_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_;
		}

		static IntPtr n_NewDeletePropertyOperation_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Internal.OperationFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.OperationFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.DeleteNodePropertyRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DeleteNodePropertyRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewDeletePropertyOperation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newDeletePropertyOperation_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.internal']/class[@name='OperationFactory']/method[@name='newDeletePropertyOperation' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.DeleteNodePropertyRequest']]"
		[Register ("newDeletePropertyOperation", "(Lcom/amazon/clouddrive/model/DeleteNodePropertyRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;", "GetNewDeletePropertyOperation_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation NewDeletePropertyOperation (global::Com.Amazon.Clouddrive.Model.DeleteNodePropertyRequest p0)
		{
			if (id_newDeletePropertyOperation_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_ == IntPtr.Zero)
				id_newDeletePropertyOperation_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_ = JNIEnv.GetMethodID (class_ref, "newDeletePropertyOperation", "(Lcom/amazon/clouddrive/model/DeleteNodePropertyRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation> (JNIEnv.CallObjectMethod  (Handle, id_newDeletePropertyOperation_Lcom_amazon_clouddrive_model_DeleteNodePropertyRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newDeletePropertyOperation", "(Lcom/amazon/clouddrive/model/DeleteNodePropertyRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_newDownloadFileOperation_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_;
#pragma warning disable 0169
		static Delegate GetNewDownloadFileOperation_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Handler ()
		{
			if (cb_newDownloadFileOperation_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_ == null)
				cb_newDownloadFileOperation_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_NewDownloadFileOperation_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_);
			return cb_newDownloadFileOperation_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_;
		}

		static IntPtr n_NewDownloadFileOperation_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Clouddrive.Internal.OperationFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.OperationFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.DownloadFileRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.DownloadFileRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Handlers.IProgressListener p1 = (global::Com.Amazon.Clouddrive.Handlers.IProgressListener)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IProgressListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewDownloadFileOperation (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newDownloadFileOperation_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.internal']/class[@name='OperationFactory']/method[@name='newDownloadFileOperation' and count(parameter)=2 and parameter[1][@type='com.amazon.clouddrive.model.DownloadFileRequest'] and parameter[2][@type='com.amazon.clouddrive.handlers.ProgressListener']]"
		[Register ("newDownloadFileOperation", "(Lcom/amazon/clouddrive/model/DownloadFileRequest;Lcom/amazon/clouddrive/handlers/ProgressListener;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;", "GetNewDownloadFileOperation_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation NewDownloadFileOperation (global::Com.Amazon.Clouddrive.Model.DownloadFileRequest p0, global::Com.Amazon.Clouddrive.Handlers.IProgressListener p1)
		{
			if (id_newDownloadFileOperation_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_ == IntPtr.Zero)
				id_newDownloadFileOperation_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_ = JNIEnv.GetMethodID (class_ref, "newDownloadFileOperation", "(Lcom/amazon/clouddrive/model/DownloadFileRequest;Lcom/amazon/clouddrive/handlers/ProgressListener;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation> (JNIEnv.CallObjectMethod  (Handle, id_newDownloadFileOperation_Lcom_amazon_clouddrive_model_DownloadFileRequest_Lcom_amazon_clouddrive_handlers_ProgressListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newDownloadFileOperation", "(Lcom/amazon/clouddrive/model/DownloadFileRequest;Lcom/amazon/clouddrive/handlers/ProgressListener;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_newGetAccountEndpointOperation_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_;
#pragma warning disable 0169
		static Delegate GetNewGetAccountEndpointOperation_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_Handler ()
		{
			if (cb_newGetAccountEndpointOperation_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_ == null)
				cb_newGetAccountEndpointOperation_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewGetAccountEndpointOperation_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_);
			return cb_newGetAccountEndpointOperation_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_;
		}

		static IntPtr n_NewGetAccountEndpointOperation_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Internal.OperationFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.OperationFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.GetAccountEndpointRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountEndpointRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewGetAccountEndpointOperation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newGetAccountEndpointOperation_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.internal']/class[@name='OperationFactory']/method[@name='newGetAccountEndpointOperation' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.GetAccountEndpointRequest']]"
		[Register ("newGetAccountEndpointOperation", "(Lcom/amazon/clouddrive/model/GetAccountEndpointRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;", "GetNewGetAccountEndpointOperation_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation NewGetAccountEndpointOperation (global::Com.Amazon.Clouddrive.Model.GetAccountEndpointRequest p0)
		{
			if (id_newGetAccountEndpointOperation_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_ == IntPtr.Zero)
				id_newGetAccountEndpointOperation_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_ = JNIEnv.GetMethodID (class_ref, "newGetAccountEndpointOperation", "(Lcom/amazon/clouddrive/model/GetAccountEndpointRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation> (JNIEnv.CallObjectMethod  (Handle, id_newGetAccountEndpointOperation_Lcom_amazon_clouddrive_model_GetAccountEndpointRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newGetAccountEndpointOperation", "(Lcom/amazon/clouddrive/model/GetAccountEndpointRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_newGetAccountInfoOperation_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_;
#pragma warning disable 0169
		static Delegate GetNewGetAccountInfoOperation_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_Handler ()
		{
			if (cb_newGetAccountInfoOperation_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_ == null)
				cb_newGetAccountInfoOperation_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewGetAccountInfoOperation_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_);
			return cb_newGetAccountInfoOperation_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_;
		}

		static IntPtr n_NewGetAccountInfoOperation_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Internal.OperationFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.OperationFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.GetAccountInfoRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountInfoRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewGetAccountInfoOperation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newGetAccountInfoOperation_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.internal']/class[@name='OperationFactory']/method[@name='newGetAccountInfoOperation' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.GetAccountInfoRequest']]"
		[Register ("newGetAccountInfoOperation", "(Lcom/amazon/clouddrive/model/GetAccountInfoRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;", "GetNewGetAccountInfoOperation_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation NewGetAccountInfoOperation (global::Com.Amazon.Clouddrive.Model.GetAccountInfoRequest p0)
		{
			if (id_newGetAccountInfoOperation_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_ == IntPtr.Zero)
				id_newGetAccountInfoOperation_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_ = JNIEnv.GetMethodID (class_ref, "newGetAccountInfoOperation", "(Lcom/amazon/clouddrive/model/GetAccountInfoRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation> (JNIEnv.CallObjectMethod  (Handle, id_newGetAccountInfoOperation_Lcom_amazon_clouddrive_model_GetAccountInfoRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newGetAccountInfoOperation", "(Lcom/amazon/clouddrive/model/GetAccountInfoRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_newGetAccountQuotaOperation_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_;
#pragma warning disable 0169
		static Delegate GetNewGetAccountQuotaOperation_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_Handler ()
		{
			if (cb_newGetAccountQuotaOperation_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_ == null)
				cb_newGetAccountQuotaOperation_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewGetAccountQuotaOperation_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_);
			return cb_newGetAccountQuotaOperation_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_;
		}

		static IntPtr n_NewGetAccountQuotaOperation_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Internal.OperationFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.OperationFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.GetAccountQuotaRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountQuotaRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewGetAccountQuotaOperation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newGetAccountQuotaOperation_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.internal']/class[@name='OperationFactory']/method[@name='newGetAccountQuotaOperation' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.GetAccountQuotaRequest']]"
		[Register ("newGetAccountQuotaOperation", "(Lcom/amazon/clouddrive/model/GetAccountQuotaRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;", "GetNewGetAccountQuotaOperation_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation NewGetAccountQuotaOperation (global::Com.Amazon.Clouddrive.Model.GetAccountQuotaRequest p0)
		{
			if (id_newGetAccountQuotaOperation_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_ == IntPtr.Zero)
				id_newGetAccountQuotaOperation_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_ = JNIEnv.GetMethodID (class_ref, "newGetAccountQuotaOperation", "(Lcom/amazon/clouddrive/model/GetAccountQuotaRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation> (JNIEnv.CallObjectMethod  (Handle, id_newGetAccountQuotaOperation_Lcom_amazon_clouddrive_model_GetAccountQuotaRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newGetAccountQuotaOperation", "(Lcom/amazon/clouddrive/model/GetAccountQuotaRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_newGetAccountUsageOperation_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_;
#pragma warning disable 0169
		static Delegate GetNewGetAccountUsageOperation_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_Handler ()
		{
			if (cb_newGetAccountUsageOperation_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_ == null)
				cb_newGetAccountUsageOperation_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewGetAccountUsageOperation_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_);
			return cb_newGetAccountUsageOperation_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_;
		}

		static IntPtr n_NewGetAccountUsageOperation_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Internal.OperationFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.OperationFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.GetAccountUsageRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountUsageRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewGetAccountUsageOperation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newGetAccountUsageOperation_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.internal']/class[@name='OperationFactory']/method[@name='newGetAccountUsageOperation' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.GetAccountUsageRequest']]"
		[Register ("newGetAccountUsageOperation", "(Lcom/amazon/clouddrive/model/GetAccountUsageRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;", "GetNewGetAccountUsageOperation_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation NewGetAccountUsageOperation (global::Com.Amazon.Clouddrive.Model.GetAccountUsageRequest p0)
		{
			if (id_newGetAccountUsageOperation_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_ == IntPtr.Zero)
				id_newGetAccountUsageOperation_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_ = JNIEnv.GetMethodID (class_ref, "newGetAccountUsageOperation", "(Lcom/amazon/clouddrive/model/GetAccountUsageRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation> (JNIEnv.CallObjectMethod  (Handle, id_newGetAccountUsageOperation_Lcom_amazon_clouddrive_model_GetAccountUsageRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newGetAccountUsageOperation", "(Lcom/amazon/clouddrive/model/GetAccountUsageRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_newGetPropertyOperation_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_;
#pragma warning disable 0169
		static Delegate GetNewGetPropertyOperation_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_Handler ()
		{
			if (cb_newGetPropertyOperation_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_ == null)
				cb_newGetPropertyOperation_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewGetPropertyOperation_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_);
			return cb_newGetPropertyOperation_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_;
		}

		static IntPtr n_NewGetPropertyOperation_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Internal.OperationFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.OperationFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.GetNodePropertyRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetNodePropertyRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewGetPropertyOperation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newGetPropertyOperation_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.internal']/class[@name='OperationFactory']/method[@name='newGetPropertyOperation' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.GetNodePropertyRequest']]"
		[Register ("newGetPropertyOperation", "(Lcom/amazon/clouddrive/model/GetNodePropertyRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;", "GetNewGetPropertyOperation_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation NewGetPropertyOperation (global::Com.Amazon.Clouddrive.Model.GetNodePropertyRequest p0)
		{
			if (id_newGetPropertyOperation_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_ == IntPtr.Zero)
				id_newGetPropertyOperation_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_ = JNIEnv.GetMethodID (class_ref, "newGetPropertyOperation", "(Lcom/amazon/clouddrive/model/GetNodePropertyRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation> (JNIEnv.CallObjectMethod  (Handle, id_newGetPropertyOperation_Lcom_amazon_clouddrive_model_GetNodePropertyRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newGetPropertyOperation", "(Lcom/amazon/clouddrive/model/GetNodePropertyRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_newListPropertiesOperation_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_;
#pragma warning disable 0169
		static Delegate GetNewListPropertiesOperation_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_Handler ()
		{
			if (cb_newListPropertiesOperation_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_ == null)
				cb_newListPropertiesOperation_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewListPropertiesOperation_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_);
			return cb_newListPropertiesOperation_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_;
		}

		static IntPtr n_NewListPropertiesOperation_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Internal.OperationFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.OperationFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ListNodePropertiesRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodePropertiesRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewListPropertiesOperation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newListPropertiesOperation_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.internal']/class[@name='OperationFactory']/method[@name='newListPropertiesOperation' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.ListNodePropertiesRequest']]"
		[Register ("newListPropertiesOperation", "(Lcom/amazon/clouddrive/model/ListNodePropertiesRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;", "GetNewListPropertiesOperation_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation NewListPropertiesOperation (global::Com.Amazon.Clouddrive.Model.ListNodePropertiesRequest p0)
		{
			if (id_newListPropertiesOperation_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_ == IntPtr.Zero)
				id_newListPropertiesOperation_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_ = JNIEnv.GetMethodID (class_ref, "newListPropertiesOperation", "(Lcom/amazon/clouddrive/model/ListNodePropertiesRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation> (JNIEnv.CallObjectMethod  (Handle, id_newListPropertiesOperation_Lcom_amazon_clouddrive_model_ListNodePropertiesRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newListPropertiesOperation", "(Lcom/amazon/clouddrive/model/ListNodePropertiesRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_newMoveNodeToTrashOperation_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_;
#pragma warning disable 0169
		static Delegate GetNewMoveNodeToTrashOperation_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_Handler ()
		{
			if (cb_newMoveNodeToTrashOperation_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_ == null)
				cb_newMoveNodeToTrashOperation_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewMoveNodeToTrashOperation_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_);
			return cb_newMoveNodeToTrashOperation_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_;
		}

		static IntPtr n_NewMoveNodeToTrashOperation_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Internal.OperationFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.OperationFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.MoveNodeToTrashRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.MoveNodeToTrashRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewMoveNodeToTrashOperation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newMoveNodeToTrashOperation_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.internal']/class[@name='OperationFactory']/method[@name='newMoveNodeToTrashOperation' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.MoveNodeToTrashRequest']]"
		[Register ("newMoveNodeToTrashOperation", "(Lcom/amazon/clouddrive/model/MoveNodeToTrashRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;", "GetNewMoveNodeToTrashOperation_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation NewMoveNodeToTrashOperation (global::Com.Amazon.Clouddrive.Model.MoveNodeToTrashRequest p0)
		{
			if (id_newMoveNodeToTrashOperation_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_ == IntPtr.Zero)
				id_newMoveNodeToTrashOperation_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_ = JNIEnv.GetMethodID (class_ref, "newMoveNodeToTrashOperation", "(Lcom/amazon/clouddrive/model/MoveNodeToTrashRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation> (JNIEnv.CallObjectMethod  (Handle, id_newMoveNodeToTrashOperation_Lcom_amazon_clouddrive_model_MoveNodeToTrashRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newMoveNodeToTrashOperation", "(Lcom/amazon/clouddrive/model/MoveNodeToTrashRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_newRemoveChildFromParentOperation_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_;
#pragma warning disable 0169
		static Delegate GetNewRemoveChildFromParentOperation_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_Handler ()
		{
			if (cb_newRemoveChildFromParentOperation_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_ == null)
				cb_newRemoveChildFromParentOperation_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewRemoveChildFromParentOperation_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_);
			return cb_newRemoveChildFromParentOperation_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_;
		}

		static IntPtr n_NewRemoveChildFromParentOperation_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Internal.OperationFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.OperationFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.RemoveChildFromParentRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.RemoveChildFromParentRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewRemoveChildFromParentOperation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newRemoveChildFromParentOperation_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.internal']/class[@name='OperationFactory']/method[@name='newRemoveChildFromParentOperation' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.RemoveChildFromParentRequest']]"
		[Register ("newRemoveChildFromParentOperation", "(Lcom/amazon/clouddrive/model/RemoveChildFromParentRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;", "GetNewRemoveChildFromParentOperation_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation NewRemoveChildFromParentOperation (global::Com.Amazon.Clouddrive.Model.RemoveChildFromParentRequest p0)
		{
			if (id_newRemoveChildFromParentOperation_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_ == IntPtr.Zero)
				id_newRemoveChildFromParentOperation_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_ = JNIEnv.GetMethodID (class_ref, "newRemoveChildFromParentOperation", "(Lcom/amazon/clouddrive/model/RemoveChildFromParentRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation> (JNIEnv.CallObjectMethod  (Handle, id_newRemoveChildFromParentOperation_Lcom_amazon_clouddrive_model_RemoveChildFromParentRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Internal.ICloudDriveOperation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newRemoveChildFromParentOperation", "(Lcom/amazon/clouddrive/model/RemoveChildFromParentRequest;)Lcom/amazon/clouddrive/internal/CloudDriveOperation;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
