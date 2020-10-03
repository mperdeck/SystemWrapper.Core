using System.ComponentModel;
using System.Diagnostics;
using SystemInterface.IO;

namespace SystemInterface.Diagnostics
{
    /// <summary>
    /// Wrapper for <see cref="Process"/> class.
    /// </summary>
    public interface IProcess
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemInterface.Diagnostics.ProcessWrap"/> class.
        /// </summary>
        void Initialize();

        // Properties

        /// <summary>
        /// Gets the value that the associated process specified when it terminated.
        /// </summary>
        [MonitoringDescription("ProcessExitCode"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        int ExitCode { get; }

        // Methods

        /// <summary>
        /// Frees all the resources that are associated with this component.
        /// </summary>
        void Close();

        /// <summary>
        /// Gets <see cref="T:System.Diagnostics.Process"/> object.
        /// </summary>
        Process ProcessInstance { get; }

        /// <summary>
        /// Starts (or reuses) the process resource that is specified by the StartInfo  property of this Process component and associates it with the component.
        /// </summary>
        /// <returns><c>true</c> if a process resource is started; false if no new process resource is started (for example, if an existing process is reused).</returns>
        bool Start();

        /// <summary>
        /// Gets or sets the properties to pass to the Start  method of the Process.
        /// </summary>
        IProcessStartInfo StartInfo { get; set; }

        /// <summary>
        /// Instructs the ProcessInstance component to wait indefinitely for the associated process to exit.
        /// </summary>
        void WaitForExit();

        /// <summary>
        /// Instructs the Process component to wait the specified number of milliseconds for the associated process to exit.
        /// </summary>
        /// <param name="milliseconds">The amount of time, in milliseconds, to wait for the associated process to exit. The maximum is the largest possible value of a 32-bit integer, which represents infinity to the operating system.</param>
        /// <returns>true if the associated process has exited; otherwise, <c>false</c>.</returns>
        bool WaitForExit(int milliseconds);

        /// <summary>
        /// Causes the Process component to wait indefinitely for the associated process to enter an idle state. This overload applies only to processes with a user interface and, therefore, a message loop.
        /// </summary>
        /// <returns>true if the associated process has reached an idle state.</returns>
        bool WaitForInputIdle();

        /// <summary>
        /// Immediately stops the Process component. The Kill method executes asynchronously. After calling the Kill method, call the WaitForExit method to wait for the process to exit, or check the HasExited property to determine if the process has exited.
        /// </summary>
        void Kill();

        /// <summary>
        /// Gets a stream used to read the output of the application.
        /// </summary>
        /// <value>
        /// A <see cref="IStreamReader"/> implementation that can be used
        /// to read the standard output stream of the application.
        /// </value>
        [MonitoringDescription("ProcessStandardOutput"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        IStreamReader StandardOutput { get; }
    }
}
