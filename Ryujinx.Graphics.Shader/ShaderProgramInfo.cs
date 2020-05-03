using System;
using System.Collections.ObjectModel;

namespace Ryujinx.Graphics.Shader
{
    [Serializable]
    public class ShaderProgramInfo
    {
        public ReadOnlyCollection<BufferDescriptor>  CBuffers { get; }
        public ReadOnlyCollection<BufferDescriptor>  SBuffers { get; }
        public ReadOnlyCollection<TextureDescriptor> Textures { get; }
        public ReadOnlyCollection<TextureDescriptor> Images   { get; }

<<<<<<< HEAD
        public bool UsesInstanceId { get; }

        internal ShaderProgramInfo(
            BufferDescriptor[]  cBuffers,
            BufferDescriptor[]  sBuffers,
            TextureDescriptor[] textures,
            TextureDescriptor[] images,
            bool                usesInstanceId)
=======
        public ReadOnlyCollection<InterpolationQualifier> InterpolationQualifiers { get; }

        public ShaderStage Stage { get; }

        public bool UsesInstanceId { get; }

        internal ShaderProgramInfo(
            BufferDescriptor[]       cBuffers,
            BufferDescriptor[]       sBuffers,
            TextureDescriptor[]      textures,
            TextureDescriptor[]      images,
            InterpolationQualifier[] interpolationQualifiers,
            ShaderStage              stage,
            bool                     usesInstanceId)
>>>>>>> 8fb330a24a72c420175b2a1e35117134b782ca29
        {
            CBuffers = Array.AsReadOnly(cBuffers);
            SBuffers = Array.AsReadOnly(sBuffers);
            Textures = Array.AsReadOnly(textures);
            Images   = Array.AsReadOnly(images);

<<<<<<< HEAD
=======
            InterpolationQualifiers = Array.AsReadOnly(interpolationQualifiers);

            Stage = stage;

>>>>>>> 8fb330a24a72c420175b2a1e35117134b782ca29
            UsesInstanceId = usesInstanceId;
        }
    }
}