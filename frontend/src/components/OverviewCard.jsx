import React from 'react';

export default function OverviewCard({ title, description }) {
  return (
    <article className="overview-card">
      <h3>{title}</h3>
      <p>{description}</p>
    </article>
  );
}
