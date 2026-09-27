# Markdown Formatting Complete Guide

Here's a comprehensive sample showing all possible Markdown formatting options:

## Headers

# H1 Header
## H2 Header
### H3 Header
#### H4 Header
##### H5 Header
###### H6 Header

Alternative H1
==============
Alternative H2
--------------

## Text Formatting

**Bold text** or __bold text__
*Italic text* or _italic text_
***Bold and italic*** or ___bold and italic___
~~Strikethrough~~
`Inline code`
<mark>Highlighted text</mark>
Normal text with <sub>subscript</sub> and <sup>superscript</sup>
<ins>Underlined text</ins>

## Lists

### Unordered Lists
- Item 1
- Item 2
  - Nested item 2.1
  - Nested item 2.2
    - Deeply nested item
- Item 3

* Alternative bullet
+ Another bullet style

### Ordered Lists
1. First item
2. Second item
   1. Nested numbered item
   2. Another nested item
3. Third item

1) Alternative numbering
2) Another style

### Task Lists
- [x] Completed task
- [ ] Incomplete task
- [ ] Another task
  - [x] Nested completed task

## Links

[Inline link](https://www.example.com)
[Link with title](https://www.example.com "Hover title")
[Reference link][1]
[Relative link](../folder/file.md)
<https://www.autolink.com>
<email@example.com>

[1]: https://www.example.com "Reference title"

## Images

![Alt text](https://via.placeholder.com/150)
![Alt text](https://via.placeholder.com/150 "Image title")
[![Image with link](https://via.placeholder.com/150)](https://www.example.com)

## Code

### Inline Code
Use `console.log()` for debugging.

### Code Blocks
```
Plain code block
No syntax highlighting
```

```javascript
// JavaScript with syntax highlighting
function greet(name) {
  console.log(`Hello, ${name}!`);
  return true;
}
```

```python
# Python example
def greet(name):
    print(f"Hello, {name}!")
    return True
```

    Indented code block
    (4 spaces or 1 tab)

## Blockquotes

> Single line blockquote

> Multi-line blockquote
> continues here
> 
> > Nested blockquote
> 
> Back to first level

> **Blockquote with formatting**
> - List in blockquote
> - Another item
> 
> `Code in blockquote`

## Tables

| Left Aligned | Center Aligned | Right Aligned |
|:-------------|:--------------:|--------------:|
| Content      | Content        | Content       |
| More         | More           | More          |
| Data         | Data           | Data          |

| Simple | Table |
|--------|-------|
| No alignment specified | Default |

## Horizontal Rules

---
***
___
- - -
* * *

## Line Breaks

First line  
Second line (two spaces at end)

First line\
Second line (backslash)

First line

Second line (empty line between)

## Escaping Characters

\* Not italic \*
\# Not a header
\[Not a link\]
\`Not code\`
\\ Backslash
\`\`\` Not a code block

## HTML in Markdown

<div align="center">
  <h3>HTML can be mixed with Markdown</h3>
  <p>This is centered text</p>
</div>

<details>
<summary>Click to expand</summary>

Hidden content here!

- Can include lists
- And other formatting

</details>

## Footnotes

Here's a sentence with a footnote[^1].

[^1]: This is the footnote content.

## Definition Lists (not standard but common)

Term 1
: Definition 1

Term 2
: Definition 2
: Alternative definition

## Abbreviations

*[HTML]: HyperText Markup Language
*[CSS]: Cascading Style Sheets

The HTML specification is maintained by the W3C.

## Emoji (GitHub style)

:smile: :heart: :thumbsup: :rocket: :tada:

Or direct Unicode: 😊 ❤️ 👍 🚀 🎉

## Mathematical Expressions (varies by platform)

Inline math: $E = mc^2$

Block math:
$$
\frac{n!}{k!(n-k)!} = \binom{n}{k}
$$

## Comments (varies by platform)

<!-- This is a comment that won't be rendered -->

[//]: # (This is also a comment)

[comment]: <> (Another comment style)

## Special Characters & Symbols

&copy; &reg; &trade; &nbsp; &mdash; &ndash; &hellip;
← ↑ → ↓ ↔ ⇒ ⇔ ∞ ∑ ∏ ∫ √ ± ≠ ≤ ≥

## Nested Combinations

> ### Header in blockquote
> 
> **Bold text** with [link](https://example.com)
> 
> ```javascript
> code in blockquote
> ```
> 
> | Table | In |
> |-------|----|
> | Quote | Block |

1. **Bold list item**
   > Quote in list
   
   ```python
   # Code in list
   print("Hello")
   ```
   
   - [ ] Task in list
     ![Image in list](https://via.placeholder.com/50)

---

## Platform-Specific Features

### GitHub
- @mentions
- #123 (issue references)
- :emoji:
- ```diff
  + Added line
  - Removed line
  ```

### GitLab
- %milestone
- !123 (merge requests)

### Discord/Slack
- ||spoiler||
- \*\*bold\*\*

## Tips for Maximum Compatibility

1. **Headers**: Always put space after #
2. **Lists**: Use consistent indentation (2 or 4 spaces)
3. **Tables**: Align pipes for readability
4. **Links**: Use reference style for repeated links
5. **Code**: Always specify language for syntax highlighting
6. **Line breaks**: Two spaces or backslash at end
7. **Escaping**: Use backslash for special characters

---

*This covers virtually all Markdown formatting options. Note that rendering may vary slightly between platforms (GitHub, GitLab, VS Code, etc.).*
