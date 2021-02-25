# dragalia-decompile

[![Decompile-latest-tag]][Decompile-tags]
[![Decompile-workflow]][Decompile-workflow-link]

Repository for decompiling the source code, also storing the decompiled results.

[Decompile-workflow]: https://github.com/RaenonX-DL/dragalia-decompile/workflows/Decompile/badge.svg
[Decompile-workflow-link]: https://github.com/RaenonX-DL/dragalia-decompile/actions?query=workflow%3ADecompile
[Decompile-latest-tag]: https://img.shields.io/github/v/tag/RaenonX-DL/dragalia-decompile?label=App%20version
[Decompile-tags]: https://github.com/RaenonX-DL/dragalia-decompile/tags

# Update procedure

1. Upload `libil2cpp.zip` containing a single file, `libil2cpp.so`.

- `libil2cpp.so` can be obtained from `data/app/com.nintendo.zaga/lib/arm64/`.

2. GH Actions will decompile it. If succeed, the decompiled results will be committed to this repository.
