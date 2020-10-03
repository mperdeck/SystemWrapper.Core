using System;
using SystemInterface.Reflection;

namespace SystemInterface
{
    /// <summary>
    /// Wrapper for <see cref="System.AppDomain"/> class.
    /// </summary>
    public interface IAppDomain
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemInterface.AppDomainWrap"/> class.
        /// </summary>
        /// <param name="appDomain">AppDomain object.</param>
        void Initialize(AppDomain appDomain);

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SystemInterface.AppDomainWrap"/> class and creates a new application domain with the specified name.
        /// </summary>
        /// <param name="friendlyName">The friendly name of the domain.</param>
        void Initialize(string friendlyName);

        // Properties

        /// <summary>
        /// Gets <see cref="T:System.AppDomain"/> object.
        /// </summary>
        AppDomain AppDomainInstance { get; }

        /// <summary>
        /// Gets the current application domain for the current Thread.
        /// </summary>
        IAppDomain CurrentDomain { get; }

        // Methods

        /// <summary>
        /// Gets the value stored in the current application domain for the specified name.
        /// </summary>
        /// <param name="name">The name of a predefined application domain property, or the name of an application domain property you have defined. </param>
        /// <returns>The value of the name property. </returns>
        object GetData(string name);

        /// <summary>
        /// Loads an Assembly given its IAssemblyNameWrap.
        /// </summary>
        /// <param name="assemblyRef">An object that describes the assembly to load.</param>
        /// <returns>The loaded assembly.</returns>
        IAssembly Load(IAssemblyName assemblyRef);

        /// <summary>
        /// Assigns the specified value to the specified application domain property.
        /// </summary>
        /// <param name="name">The name of a user-defined application domain property to create or change.</param>
        /// <param name="data">The value of the property.</param>
        void SetData(string name, object data);

        /// <summary>
        /// Unloads the specified application domain.
        /// </summary>
        /// <param name="domain">An application domain to unload.</param>
        void Unload(IAppDomain domain);

        // Events

        /// <summary>
        /// Occurs when the resolution of an assembly fails.
        /// </summary>
        event ResolveEventHandler AssemblyResolve;
    }
}
