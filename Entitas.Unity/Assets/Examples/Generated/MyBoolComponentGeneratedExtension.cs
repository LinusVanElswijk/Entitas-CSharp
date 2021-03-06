//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {
    public partial class Entity {
        public MyBoolComponent myBool { get { return (MyBoolComponent)GetComponent(ComponentIds.MyBool); } }

        public bool hasMyBool { get { return HasComponent(ComponentIds.MyBool); } }

        public Entity AddMyBool(bool newMyBool) {
            var component = CreateComponent<MyBoolComponent>(ComponentIds.MyBool);
            component.myBool = newMyBool;
            return AddComponent(ComponentIds.MyBool, component);
        }

        public Entity ReplaceMyBool(bool newMyBool) {
            var component = CreateComponent<MyBoolComponent>(ComponentIds.MyBool);
            component.myBool = newMyBool;
            ReplaceComponent(ComponentIds.MyBool, component);
            return this;
        }

        public Entity RemoveMyBool() {
            return RemoveComponent(ComponentIds.MyBool);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherMyBool;

        public static IMatcher MyBool {
            get {
                if (_matcherMyBool == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.MyBool);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherMyBool = matcher;
                }

                return _matcherMyBool;
            }
        }
    }
}
