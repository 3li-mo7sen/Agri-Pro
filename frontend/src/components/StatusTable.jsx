import React from 'react';

export default function StatusTable({ rows }) {
  return (
    <div className="status-table">
      {rows.map((row) => (
        <div className="status-row" key={row.label}>
          <div>
            <p className="status-label">{row.label}</p>
            <p className="status-note">{row.note}</p>
          </div>
          <span className="status-value">{row.value}</span>
        </div>
      ))}
    </div>
  );
}
