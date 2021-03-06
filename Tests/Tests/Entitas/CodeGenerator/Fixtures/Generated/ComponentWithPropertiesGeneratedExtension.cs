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
        public ComponentWithProperties componentWithProperties { get { return (ComponentWithProperties)GetComponent(ComponentIds.ComponentWithProperties); } }

        public bool hasComponentWithProperties { get { return HasComponent(ComponentIds.ComponentWithProperties); } }

        public Entity AddComponentWithProperties(string newPublicProperty) {
            var component = CreateComponent<ComponentWithProperties>(ComponentIds.ComponentWithProperties);
            component.publicProperty = newPublicProperty;
            return AddComponent(ComponentIds.ComponentWithProperties, component);
        }

        public Entity ReplaceComponentWithProperties(string newPublicProperty) {
            var component = CreateComponent<ComponentWithProperties>(ComponentIds.ComponentWithProperties);
            component.publicProperty = newPublicProperty;
            ReplaceComponent(ComponentIds.ComponentWithProperties, component);
            return this;
        }

        public Entity RemoveComponentWithProperties() {
            return RemoveComponent(ComponentIds.ComponentWithProperties);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherComponentWithProperties;

        public static IMatcher ComponentWithProperties {
            get {
                if (_matcherComponentWithProperties == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.ComponentWithProperties);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherComponentWithProperties = matcher;
                }

                return _matcherComponentWithProperties;
            }
        }
    }
}
