import React from 'react';

export default function ModuleSection({ title, items }) {
  return (
    <article className="module-card">
      <h3>{title}</h3>
      <ul>
        {items.map((item) => (
          <li key={item}>{item}</li>
        ))}
      </ul>
    </article>
  );
}
