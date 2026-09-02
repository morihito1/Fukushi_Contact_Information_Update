using UiPath.CodedWorkflows.DescriptorIntegration;

namespace 福祉連絡先更新.ObjectRepository
{
    public static class Descriptors
    {
        public static class __Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局
        {
            static string _reference = "c_veQxnNcEqCAHsgKse5tg/63W88Cy4-ki0iiJXAenEfA";
            public static _Implementation.___Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局.__Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局 Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局 { get; private set; } = new _Implementation.___Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局.__Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局();
        }
    }
}

namespace 福祉連絡先更新._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }
        public string Reference { get; set; }
        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }
        public string Reference { get; set; }
        public string DisplayName { get; set; }
        public IElementDescriptor ParentElement { get; set; }
        public IElementDescriptor Element { get; set; }
    }

    namespace ___Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局._Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局
    {
        public class ___区市町村_障害者虐待防止センター_令和8年4_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___区市町村_障害者虐待防止センター_令和8年4_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "c_veQxnNcEqCAHsgKse5tg/HuGgbkO9X0C8_OVX4YyW1w",
                    DisplayName = "【区市町村】障害者虐待防止センター（令和8年4…",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局._Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局
    {
        public class __アドレス_CUsersiwannOn_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __アドレス_CUsersiwannOn_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "c_veQxnNcEqCAHsgKse5tg/Dz-gOvzjSEaaw7qlMV48-Q",
                    DisplayName = "アドレス CUsersiwannOn…",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局._Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局
    {
        public class __アドレス_ダウンロード : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __アドレス_ダウンロード(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "c_veQxnNcEqCAHsgKse5tg/ZwHIJNNFFUSYwLgaXGKLyg",
                    DisplayName = "アドレス ダウンロード",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局._Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局
    {
        public class __ウィンドウ操作___ウィンドウをフォアグラウンドに移動 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __ウィンドウ操作___ウィンドウをフォアグラウンドに移動(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "c_veQxnNcEqCAHsgKse5tg/hPLtH-wiVU6I8R4Tgghc2Q",
                    DisplayName = "ウィンドウ操作 - ウィンドウをフォアグラウンドに移動",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局
    {
        public class __Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局 : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "c_veQxnNcEqCAHsgKse5tg/tkBEvfdgvEaFItzVONcZrg",
                    DisplayName = "Chrome 通報・届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局",
                    Screen = this
                };
                _区市町村_障害者虐待防止センター_令和8年4_ = new _Implementation.___Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局._Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局.___区市町村_障害者虐待防止センター_令和8年4_(this, null);
                アドレス_CUsersiwannOn_ = new _Implementation.___Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局._Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局.__アドレス_CUsersiwannOn_(this, null);
                アドレス_ダウンロード = new _Implementation.___Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局._Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局.__アドレス_ダウンロード(this, null);
                ウィンドウ操作___ウィンドウをフォアグラウンドに移動 = new _Implementation.___Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局._Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局.__ウィンドウ操作___ウィンドウをフォアグラウンドに移動(this, null);
            }

            public _Implementation.___Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局._Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局.___区市町村_障害者虐待防止センター_令和8年4_ _区市町村_障害者虐待防止センター_令和8年4_ { get; private set; }
            public _Implementation.___Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局._Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局.__アドレス_CUsersiwannOn_ アドレス_CUsersiwannOn_ { get; private set; }
            public _Implementation.___Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局._Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局.__アドレス_ダウンロード アドレス_ダウンロード { get; private set; }
            public _Implementation.___Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局._Chrome_通報_届出等窓口一覧障害者虐待防止と権利擁護東京都福祉局.__ウィンドウ操作___ウィンドウをフォアグラウンドに移動 ウィンドウ操作___ウィンドウをフォアグラウンドに移動 { get; private set; }
        }
    }
}