using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Auth {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.clouddrive.auth']/interface[@name='AuthenticatedURLConnectionFactory']"
	[Register ("com/amazon/clouddrive/auth/AuthenticatedURLConnectionFactory", "", "Com.Amazon.Clouddrive.Auth.IAuthenticatedURLConnectionFactoryInvoker")]
	public partial interface IAuthenticatedURLConnectionFactory : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.auth']/interface[@name='AuthenticatedURLConnectionFactory']/method[@name='createHttpURLConnection' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register ("createHttpURLConnection", "(Ljava/net/URL;)Ljava/net/HttpURLConnection;", "GetCreateHttpURLConnection_Ljava_net_URL_Handler:Com.Amazon.Clouddrive.Auth.IAuthenticatedURLConnectionFactoryInvoker, CloudDriveAPI")]
		global::Java.Net.HttpURLConnection CreateHttpURLConnection (global::Java.Net.URL p0);

	}

	[global::Android.Runtime.Register ("com/amazon/clouddrive/auth/AuthenticatedURLConnectionFactory", DoNotGenerateAcw=true)]
	internal class IAuthenticatedURLConnectionFactoryInvoker : global::Java.Lang.Object, IAuthenticatedURLConnectionFactory {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/clouddrive/auth/AuthenticatedURLConnectionFactory");
		IntPtr class_ref;

		public static IAuthenticatedURLConnectionFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAuthenticatedURLConnectionFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.clouddrive.auth.AuthenticatedURLConnectionFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAuthenticatedURLConnectionFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAuthenticatedURLConnectionFactoryInvoker); }
		}

		static Delegate cb_createHttpURLConnection_Ljava_net_URL_;
#pragma warning disable 0169
		static Delegate GetCreateHttpURLConnection_Ljava_net_URL_Handler ()
		{
			if (cb_createHttpURLConnection_Ljava_net_URL_ == null)
				cb_createHttpURLConnection_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateHttpURLConnection_Ljava_net_URL_);
			return cb_createHttpURLConnection_Ljava_net_URL_;
		}

		static IntPtr n_CreateHttpURLConnection_Ljava_net_URL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Auth.IAuthenticatedURLConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Auth.IAuthenticatedURLConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URL p0 = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateHttpURLConnection (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createHttpURLConnection_Ljava_net_URL_;
		public unsafe global::Java.Net.HttpURLConnection CreateHttpURLConnection (global::Java.Net.URL p0)
		{
			if (id_createHttpURLConnection_Ljava_net_URL_ == IntPtr.Zero)
				id_createHttpURLConnection_Ljava_net_URL_ = JNIEnv.GetMethodID (class_ref, "createHttpURLConnection", "(Ljava/net/URL;)Ljava/net/HttpURLConnection;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Java.Net.HttpURLConnection __ret = global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (JNIEnv.CallObjectMethod (Handle, id_createHttpURLConnection_Ljava_net_URL_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
