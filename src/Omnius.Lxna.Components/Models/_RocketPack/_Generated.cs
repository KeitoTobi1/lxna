// <auto-generated/>
#nullable enable

namespace Omnius.Lxna.Components.Models
{
    public enum ThumbnailResizeType : byte
    {
        Pad = 0,
        Crop = 1,
    }
    public enum ThumbnailFormatType : byte
    {
        Png = 0,
    }
    public sealed partial class NestedPath : global::Omnius.Core.RocketPack.IRocketPackObject<global::Omnius.Lxna.Components.Models.NestedPath>
    {
        public static global::Omnius.Core.RocketPack.IRocketPackObjectFormatter<global::Omnius.Lxna.Components.Models.NestedPath> Formatter => global::Omnius.Core.RocketPack.IRocketPackObject<global::Omnius.Lxna.Components.Models.NestedPath>.Formatter;
        public static global::Omnius.Lxna.Components.Models.NestedPath Empty => global::Omnius.Core.RocketPack.IRocketPackObject<global::Omnius.Lxna.Components.Models.NestedPath>.Empty;

        static NestedPath()
        {
            global::Omnius.Core.RocketPack.IRocketPackObject<global::Omnius.Lxna.Components.Models.NestedPath>.Formatter = new ___CustomFormatter();
            global::Omnius.Core.RocketPack.IRocketPackObject<global::Omnius.Lxna.Components.Models.NestedPath>.Empty = new global::Omnius.Lxna.Components.Models.NestedPath(global::System.Array.Empty<string>());
        }

        private readonly global::System.Lazy<int> ___hashCode;

        public static readonly int MaxValuesCount = 32;

        public NestedPath(string[] values)
        {
            if (values is null) throw new global::System.ArgumentNullException("values");
            if (values.Length > 32) throw new global::System.ArgumentOutOfRangeException("values");
            foreach (var n in values)
            {
                if (n is null) throw new global::System.ArgumentNullException("n");
                if (n.Length > 8192) throw new global::System.ArgumentOutOfRangeException("n");
            }

            this.Values = new global::Omnius.Core.Collections.ReadOnlyListSlim<string>(values);

            ___hashCode = new global::System.Lazy<int>(() =>
            {
                var ___h = new global::System.HashCode();
                foreach (var n in values)
                {
                    if (n != default) ___h.Add(n.GetHashCode());
                }
                return ___h.ToHashCode();
            });
        }

        public global::Omnius.Core.Collections.ReadOnlyListSlim<string> Values { get; }

        public static global::Omnius.Lxna.Components.Models.NestedPath Import(global::System.Buffers.ReadOnlySequence<byte> sequence, global::Omnius.Core.IBytesPool bytesPool)
        {
            var reader = new global::Omnius.Core.RocketPack.RocketPackObjectReader(sequence, bytesPool);
            return Formatter.Deserialize(ref reader, 0);
        }
        public void Export(global::System.Buffers.IBufferWriter<byte> bufferWriter, global::Omnius.Core.IBytesPool bytesPool)
        {
            var writer = new global::Omnius.Core.RocketPack.RocketPackObjectWriter(bufferWriter, bytesPool);
            Formatter.Serialize(ref writer, this, 0);
        }

        public static bool operator ==(global::Omnius.Lxna.Components.Models.NestedPath? left, global::Omnius.Lxna.Components.Models.NestedPath? right)
        {
            return (right is null) ? (left is null) : right.Equals(left);
        }
        public static bool operator !=(global::Omnius.Lxna.Components.Models.NestedPath? left, global::Omnius.Lxna.Components.Models.NestedPath? right)
        {
            return !(left == right);
        }
        public override bool Equals(object? other)
        {
            if (other is not global::Omnius.Lxna.Components.Models.NestedPath) return false;
            return this.Equals((global::Omnius.Lxna.Components.Models.NestedPath)other);
        }
        public bool Equals(global::Omnius.Lxna.Components.Models.NestedPath? target)
        {
            if (target is null) return false;
            if (object.ReferenceEquals(this, target)) return true;
            if (!global::Omnius.Core.Helpers.CollectionHelper.Equals(this.Values, target.Values)) return false;

            return true;
        }
        public override int GetHashCode() => ___hashCode.Value;

        private sealed class ___CustomFormatter : global::Omnius.Core.RocketPack.IRocketPackObjectFormatter<global::Omnius.Lxna.Components.Models.NestedPath>
        {
            public void Serialize(ref global::Omnius.Core.RocketPack.RocketPackObjectWriter w, in global::Omnius.Lxna.Components.Models.NestedPath value, in int rank)
            {
                if (rank > 256) throw new global::System.FormatException();

                if (value.Values.Count != 0)
                {
                    w.Write((uint)1);
                    w.Write((uint)value.Values.Count);
                    foreach (var n in value.Values)
                    {
                        w.Write(n);
                    }
                }
                w.Write((uint)0);
            }
            public global::Omnius.Lxna.Components.Models.NestedPath Deserialize(ref global::Omnius.Core.RocketPack.RocketPackObjectReader r, in int rank)
            {
                if (rank > 256) throw new global::System.FormatException();

                string[] p_values = global::System.Array.Empty<string>();

                for (; ; )
                {
                    uint id = r.GetUInt32();
                    if (id == 0) break;
                    switch (id)
                    {
                        case 1:
                            {
                                var length = r.GetUInt32();
                                p_values = new string[length];
                                for (int i = 0; i < p_values.Length; i++)
                                {
                                    p_values[i] = r.GetString(8192);
                                }
                                break;
                            }
                    }
                }

                return new global::Omnius.Lxna.Components.Models.NestedPath(p_values);
            }
        }
    }
    public sealed partial class ThumbnailContent : global::Omnius.Core.RocketPack.IRocketPackObject<global::Omnius.Lxna.Components.Models.ThumbnailContent>, global::System.IDisposable
    {
        public static global::Omnius.Core.RocketPack.IRocketPackObjectFormatter<global::Omnius.Lxna.Components.Models.ThumbnailContent> Formatter => global::Omnius.Core.RocketPack.IRocketPackObject<global::Omnius.Lxna.Components.Models.ThumbnailContent>.Formatter;
        public static global::Omnius.Lxna.Components.Models.ThumbnailContent Empty => global::Omnius.Core.RocketPack.IRocketPackObject<global::Omnius.Lxna.Components.Models.ThumbnailContent>.Empty;

        static ThumbnailContent()
        {
            global::Omnius.Core.RocketPack.IRocketPackObject<global::Omnius.Lxna.Components.Models.ThumbnailContent>.Formatter = new ___CustomFormatter();
            global::Omnius.Core.RocketPack.IRocketPackObject<global::Omnius.Lxna.Components.Models.ThumbnailContent>.Empty = new global::Omnius.Lxna.Components.Models.ThumbnailContent(global::Omnius.Core.MemoryOwner<byte>.Empty);
        }

        private readonly global::System.Lazy<int> ___hashCode;

        public static readonly int MaxImageLength = 33554432;

        public ThumbnailContent(global::System.Buffers.IMemoryOwner<byte> image)
        {
            if (image is null) throw new global::System.ArgumentNullException("image");
            if (image.Memory.Length > 33554432) throw new global::System.ArgumentOutOfRangeException("image");

            _image = image;

            ___hashCode = new global::System.Lazy<int>(() =>
            {
                var ___h = new global::System.HashCode();
                if (!image.Memory.IsEmpty) ___h.Add(global::Omnius.Core.Helpers.ObjectHelper.GetHashCode(image.Memory.Span));
                return ___h.ToHashCode();
            });
        }

        private readonly global::System.Buffers.IMemoryOwner<byte> _image;
        public global::System.ReadOnlyMemory<byte> Image => _image.Memory;

        public static global::Omnius.Lxna.Components.Models.ThumbnailContent Import(global::System.Buffers.ReadOnlySequence<byte> sequence, global::Omnius.Core.IBytesPool bytesPool)
        {
            var reader = new global::Omnius.Core.RocketPack.RocketPackObjectReader(sequence, bytesPool);
            return Formatter.Deserialize(ref reader, 0);
        }
        public void Export(global::System.Buffers.IBufferWriter<byte> bufferWriter, global::Omnius.Core.IBytesPool bytesPool)
        {
            var writer = new global::Omnius.Core.RocketPack.RocketPackObjectWriter(bufferWriter, bytesPool);
            Formatter.Serialize(ref writer, this, 0);
        }

        public static bool operator ==(global::Omnius.Lxna.Components.Models.ThumbnailContent? left, global::Omnius.Lxna.Components.Models.ThumbnailContent? right)
        {
            return (right is null) ? (left is null) : right.Equals(left);
        }
        public static bool operator !=(global::Omnius.Lxna.Components.Models.ThumbnailContent? left, global::Omnius.Lxna.Components.Models.ThumbnailContent? right)
        {
            return !(left == right);
        }
        public override bool Equals(object? other)
        {
            if (other is not global::Omnius.Lxna.Components.Models.ThumbnailContent) return false;
            return this.Equals((global::Omnius.Lxna.Components.Models.ThumbnailContent)other);
        }
        public bool Equals(global::Omnius.Lxna.Components.Models.ThumbnailContent? target)
        {
            if (target is null) return false;
            if (object.ReferenceEquals(this, target)) return true;
            if (!global::Omnius.Core.BytesOperations.Equals(this.Image.Span, target.Image.Span)) return false;

            return true;
        }
        public override int GetHashCode() => ___hashCode.Value;

        public void Dispose()
        {
            _image?.Dispose();
        }

        private sealed class ___CustomFormatter : global::Omnius.Core.RocketPack.IRocketPackObjectFormatter<global::Omnius.Lxna.Components.Models.ThumbnailContent>
        {
            public void Serialize(ref global::Omnius.Core.RocketPack.RocketPackObjectWriter w, in global::Omnius.Lxna.Components.Models.ThumbnailContent value, in int rank)
            {
                if (rank > 256) throw new global::System.FormatException();

                if (!value.Image.IsEmpty)
                {
                    w.Write((uint)1);
                    w.Write(value.Image.Span);
                }
                w.Write((uint)0);
            }
            public global::Omnius.Lxna.Components.Models.ThumbnailContent Deserialize(ref global::Omnius.Core.RocketPack.RocketPackObjectReader r, in int rank)
            {
                if (rank > 256) throw new global::System.FormatException();

                global::System.Buffers.IMemoryOwner<byte> p_image = global::Omnius.Core.MemoryOwner<byte>.Empty;

                for (; ; )
                {
                    uint id = r.GetUInt32();
                    if (id == 0) break;
                    switch (id)
                    {
                        case 1:
                            {
                                p_image = r.GetRecyclableMemory(33554432);
                                break;
                            }
                    }
                }

                return new global::Omnius.Lxna.Components.Models.ThumbnailContent(p_image);
            }
        }
    }
    public sealed partial class ThumbnailGeneratorOptions : global::Omnius.Core.RocketPack.IRocketPackObject<global::Omnius.Lxna.Components.Models.ThumbnailGeneratorOptions>
    {
        public static global::Omnius.Core.RocketPack.IRocketPackObjectFormatter<global::Omnius.Lxna.Components.Models.ThumbnailGeneratorOptions> Formatter => global::Omnius.Core.RocketPack.IRocketPackObject<global::Omnius.Lxna.Components.Models.ThumbnailGeneratorOptions>.Formatter;
        public static global::Omnius.Lxna.Components.Models.ThumbnailGeneratorOptions Empty => global::Omnius.Core.RocketPack.IRocketPackObject<global::Omnius.Lxna.Components.Models.ThumbnailGeneratorOptions>.Empty;

        static ThumbnailGeneratorOptions()
        {
            global::Omnius.Core.RocketPack.IRocketPackObject<global::Omnius.Lxna.Components.Models.ThumbnailGeneratorOptions>.Formatter = new ___CustomFormatter();
            global::Omnius.Core.RocketPack.IRocketPackObject<global::Omnius.Lxna.Components.Models.ThumbnailGeneratorOptions>.Empty = new global::Omnius.Lxna.Components.Models.ThumbnailGeneratorOptions(0);
        }

        private readonly global::System.Lazy<int> ___hashCode;

        public ThumbnailGeneratorOptions(uint concurrency)
        {
            this.Concurrency = concurrency;

            ___hashCode = new global::System.Lazy<int>(() =>
            {
                var ___h = new global::System.HashCode();
                if (concurrency != default) ___h.Add(concurrency.GetHashCode());
                return ___h.ToHashCode();
            });
        }

        public uint Concurrency { get; }

        public static global::Omnius.Lxna.Components.Models.ThumbnailGeneratorOptions Import(global::System.Buffers.ReadOnlySequence<byte> sequence, global::Omnius.Core.IBytesPool bytesPool)
        {
            var reader = new global::Omnius.Core.RocketPack.RocketPackObjectReader(sequence, bytesPool);
            return Formatter.Deserialize(ref reader, 0);
        }
        public void Export(global::System.Buffers.IBufferWriter<byte> bufferWriter, global::Omnius.Core.IBytesPool bytesPool)
        {
            var writer = new global::Omnius.Core.RocketPack.RocketPackObjectWriter(bufferWriter, bytesPool);
            Formatter.Serialize(ref writer, this, 0);
        }

        public static bool operator ==(global::Omnius.Lxna.Components.Models.ThumbnailGeneratorOptions? left, global::Omnius.Lxna.Components.Models.ThumbnailGeneratorOptions? right)
        {
            return (right is null) ? (left is null) : right.Equals(left);
        }
        public static bool operator !=(global::Omnius.Lxna.Components.Models.ThumbnailGeneratorOptions? left, global::Omnius.Lxna.Components.Models.ThumbnailGeneratorOptions? right)
        {
            return !(left == right);
        }
        public override bool Equals(object? other)
        {
            if (other is not global::Omnius.Lxna.Components.Models.ThumbnailGeneratorOptions) return false;
            return this.Equals((global::Omnius.Lxna.Components.Models.ThumbnailGeneratorOptions)other);
        }
        public bool Equals(global::Omnius.Lxna.Components.Models.ThumbnailGeneratorOptions? target)
        {
            if (target is null) return false;
            if (object.ReferenceEquals(this, target)) return true;
            if (this.Concurrency != target.Concurrency) return false;

            return true;
        }
        public override int GetHashCode() => ___hashCode.Value;

        private sealed class ___CustomFormatter : global::Omnius.Core.RocketPack.IRocketPackObjectFormatter<global::Omnius.Lxna.Components.Models.ThumbnailGeneratorOptions>
        {
            public void Serialize(ref global::Omnius.Core.RocketPack.RocketPackObjectWriter w, in global::Omnius.Lxna.Components.Models.ThumbnailGeneratorOptions value, in int rank)
            {
                if (rank > 256) throw new global::System.FormatException();

                if (value.Concurrency != 0)
                {
                    w.Write((uint)1);
                    w.Write(value.Concurrency);
                }
                w.Write((uint)0);
            }
            public global::Omnius.Lxna.Components.Models.ThumbnailGeneratorOptions Deserialize(ref global::Omnius.Core.RocketPack.RocketPackObjectReader r, in int rank)
            {
                if (rank > 256) throw new global::System.FormatException();

                uint p_concurrency = 0;

                for (; ; )
                {
                    uint id = r.GetUInt32();
                    if (id == 0) break;
                    switch (id)
                    {
                        case 1:
                            {
                                p_concurrency = r.GetUInt32();
                                break;
                            }
                    }
                }

                return new global::Omnius.Lxna.Components.Models.ThumbnailGeneratorOptions(p_concurrency);
            }
        }
    }
}