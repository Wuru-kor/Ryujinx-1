using Ryujinx.Graphics.Shader;

namespace Ryujinx.Graphics.GAL
{
    public interface IPipeline
    {
        void Barrier();

        void ClearRenderTargetColor(int index, uint componentMask, ColorF color);

        void ClearRenderTargetDepthStencil(
            float depthValue,
            bool  depthMask,
            int   stencilValue,
            int   stencilMask);

        void DispatchCompute(int groupsX, int groupsY, int groupsZ);

        void Draw(int vertexCount, int instanceCount, int firstVertex, int firstInstance);
        void DrawIndexed(
            int indexCount,
            int instanceCount,
            int firstIndex,
            int firstVertex,
            int firstInstance);

        void SetBlendState(int index, BlendDescriptor blend);

        void SetDepthBias(PolygonModeMask enables, float factor, float units, float clamp);
        void SetDepthClamp(bool clamp);
        void SetDepthMode(DepthMode mode);
        void SetDepthTest(DepthTestDescriptor depthTest);

        void SetFaceCulling(bool enable, Face face);

        void SetFrontFace(FrontFace frontFace);

        void SetIndexBuffer(BufferRange buffer, IndexType type);

        void SetImage(int unit, ITexture texture);

        void SetPointSize(float size);

        void SetPrimitiveRestart(bool enable, int index);

        void SetPrimitiveTopology(PrimitiveTopology topology);

        void SetProgram(IProgram program);

        void SetRasterizerDiscard(bool discard);

        void SetRenderTargetColorMasks(uint[] componentMask);

        void SetRenderTargets(ITexture[] colors, ITexture depthStencil);

        void SetSampler(int unit, ISampler sampler);

        void SetScissorEnable(int index, bool enable);
        void SetScissor(int index, int x, int y, int width, int height);

        void SetStencilTest(StencilTestDescriptor stencilTest);

        void SetStorageBuffer(int bindingPoint, BufferRange buffer);

        void SetTexture(int unit, ITexture texture);

        void SetUniformBuffer(int bindingPoint, BufferRange buffer);

        void SetVertexAttribs(VertexAttribDescriptor[] vertexAttribs);
        void SetVertexBuffers(VertexBufferDescriptor[] vertexBuffers);

        void SetViewports(int first, Viewport[] viewports);

        void TextureBarrier();
        void TextureBarrierTiled();

        bool TryHostConditionalRendering(object value, object compare, bool isEqual);
        void EndHostConditionalRendering();
    }
}
