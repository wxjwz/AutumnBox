﻿namespace AutumnBox.OpenFramework.Extension
{
    /// <summary>
    /// 拓展模块是否是开发人员模式
    /// </summary>
    public class ExtDeveloperMode : ExtInfoAttribute
    {
        /// <summary>
        /// Key
        /// </summary>
        public override string Key => ExtensionMetadataKeys.IS_DEVELOPING;
        /// <summary>
        /// 构造
        /// </summary>
        /// <param name="value"></param>
        public ExtDeveloperMode(bool value) : base(value)
        {
        }
        /// <summary>
        /// 构造
        /// </summary>
        public ExtDeveloperMode() : this(true) { }
    }
}
