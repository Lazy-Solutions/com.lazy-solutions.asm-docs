# Advanced Scene Manager Documentation

This repository contains the official documentation for
**Advanced Scene Manager**.

- 📁 [Browse guides](guides/readme.md)
- 📁 [Browse API Reference](api/readme.md)

↪ [View this repository on GitHub](https://github.com/Lazy-Solutions/AdvancedSceneManager/tree/main/docs)

### Notes:
<details>
  <summary><b>Issues on first start</b></summary>
  </br>
  There is currently an issue with first startup. This is due to UI toolkit not binding properly for whatever reason, resulting in collections and dynamic collection lists being empty. Another issue can be missing icons for collection or scene buttons. This has hopefully been fixed in dev, and will be pushed when 3.2 is ready.

  For now, a domain reload will fix it. Either:
  - Restart unity
  - Right click ASM window menu button (most upper right button), and choose Reload domain.

</details>

<details>
   <summary><b>Upgrading to 3.0 (from 2.x)</b></summary>
</br>
Upgrading should be straightforward: just uninstall 2.0 and install 3.0. Everything should keep working as before, ASM assets are either unchanged or automatically upgraded.

We recommend backing up your project first (always a good idea when updating major versions).

While 3.0 carries a major version bump, most of the changes are under the hood. You’ll notice some UI improvements, but the bigger updates are in the backend. Many of these lay the groundwork for future features and advanced use cases, so for most users, the upgrade will feel smooth and familiar.

Most of the 2.0 documentation still applies to 3.0. That said, there may be a few places where things have changed and aren’t fully documented yet, we’re working on updating those. The generated API docs also haven’t been refreshed yet, so the new APIs are currently missing. We’re building our own in-house tool for this to avoid relying on fragile toolchains, which should make the docs more reliable going forward.

</details>
