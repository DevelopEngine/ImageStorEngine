# ImageStorEngine

## Part of **DevelopEngine**

A reusable, opinionated drop-in service for storing, indexing and managing images, useful for APIs and local applications.

Note that this package *can* be repurposed to work with general files, but this is not recommended at this time.

> ***Warning***: This package is likely to be completely refactored at a later date to use platform abstractions, instead of exposing `System.IO` directly. If you must depend on this project, make sure to only use the `0.1.x` versions (which will be kept using `System.IO` types).